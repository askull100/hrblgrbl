using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//required namespaces
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using MyThreadObject;

namespace Server
{
    public partial class ServerForm : Form
    {
        //My channels
        private const int COM_PORT = 8080;
        private const int DAT_PORT = 8090;

        //My threads alive bools
        private bool bCommandListener = false;
        private bool bDataListener = false;

        //My Listeners Threads
        private Thread CommandThreadListener = null;
        private Thread DataThreadListener = null;

        //List of my connections
        Dictionary<string, ThreadObject> ListOfServerThreads = new Dictionary<string, ThreadObject>();

        public ServerForm()
        {
            InitializeComponent();
            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            this.Text = "TCP/IP - " + IPHost.AddressList[0].ToString();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //=====START THE LISTENERS
            //Start the Command Listener
            CommandThreadListener = new Thread(new ThreadStart(CommandListener));
            bCommandListener = true;
            CommandThreadListener.Start();
            //Start the Data Listener
            DataThreadListener = new Thread(new ThreadStart(DataListener));
            bDataListener = true;
            DataThreadListener.Start();
        }

        private void CommandListener()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, COM_PORT);
            tcpListener.Start();
            
            while(bCommandListener == true)
            {
                while(tcpListener.Pending() == false)
                {
                    if (bCommandListener == false)
                        break;
                }

                //This will stop the thread and exits
                if(bCommandListener == false)
                {
                    tcpListener.Stop();
                    break;
                }

                //You are here because a new connection
                Socket client = tcpListener.AcceptSocket();
                if(client.Connected == true)
                {
                    ThreadObject clientThread = new ThreadObject();
                    clientThread.client = client;
                    clientThread.ThreadDel = new ThreadObject.ThreadDelegate(CommandProcessHandler);
                    clientThread.StartThread();
                    //Map the IP of the connection(key) to the ThreadObject(value)
                    string ip = "COM_" + (client.RemoteEndPoint as IPEndPoint).Address.ToString();
                    ListOfServerThreads.Add(ip, clientThread);
                    UpdateConnectionsListBox(ip);
                }
            }
        }

        private void DataListener()
        {

        }

        private delegate void UpdateConnectionDel(string ip);
        private void UpdateConnectionsListBox(string ip)
        {
            if(this.InvokeRequired)
            {
                UpdateConnectionDel UpdateDel = new UpdateConnectionDel(UpdateConnectionsListBox);
                this.Invoke(UpdateDel, new object[] { ip });
            }
            else
            {
                ListOfConnections.Items.Add(ip);
            }
        }

        //Threading for communicating the commands with the client
        private void CommandProcessHandler(Socket client)
        {
            Byte[] data = new Byte[1024];
            NetworkStream NetStream = new NetworkStream(client);

            //Read the command from the client
            int bytes = NetStream.Read(data, 0, 1024);
            string Command = Encoding.ASCII.GetString(data, 0, bytes);
            //Do something with the command
            //........
            //Display the command in the command list box
            Command = ((client.RemoteEndPoint) as IPEndPoint).Address.ToString() + ">>>" + Command;
            UpdateCommandsListBox(Command);
        }

        private delegate void UpdateCommandLBDel(string command);
        private void UpdateCommandsListBox(string command)
        {
            if (this.InvokeRequired)
            {
                UpdateCommandLBDel UpdateDel = new UpdateCommandLBDel(UpdateCommandsListBox);
                this.Invoke(UpdateDel, new object[] { command });
            }
            else
            {
                ListOfCommands.Items.Add(command);
            }
        }
    }
}
