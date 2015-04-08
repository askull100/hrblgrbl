﻿using System;
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
using CommLib;

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

        private bool ThreadRunning = false;

        //My Listeners Threads
        private Thread CommandThreadListener = null;
        private Thread DataThreadListener = null;

        TcpListener tcpListener = null;

        public bool m_IsHost = false;
        public string m_Password = null;
        public string m_CompareString;

        //List of my connections
        Dictionary<string, ThreadObject> ListOfServerThreads = new Dictionary<string, ThreadObject>();

        private Object __object = new Object();

        public ServerForm()
        {
            InitializeComponent();
            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            this.Text = "Tic Tac Toe - Hosted By" + IPHost.AddressList[0].ToString();

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

        public ServerForm(bool isHost)
        {
            InitializeComponent();
            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            if (isHost == true)
                this.Text = "Tic Tac Toe - You Are Hosting";
            else
                this.Text = "Tic Tac Toe - Hosted By" + IPHost.AddressList[0].ToString();

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
            tcpListener = new TcpListener(IPAddress.Any, COM_PORT);
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

        private delegate void ClearConnectionsDel();
        private void ClearConnetionsListBox()
        {
            if(this.InvokeRequired)
            {
                ClearConnectionsDel ClearDel = new ClearConnectionsDel(ClearConnetionsListBox);
                this.Invoke(ClearDel);
            }
            else
            {
                ListOfConnections.Items.Clear();
            }
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
            NetworkStream NetStream = null;
            ThreadRunning = true;

            //Exception check
            if(client.Connected == true)
                NetStream = new NetworkStream(client);

            while(ThreadRunning == true)
            {
                int bytes = 0;
                string Command = string.Empty;
                //Read the command from the client
                try
                {
                    bytes = NetStream.Read(data, 0, 1024);
                    Command = Encoding.ASCII.GetString(data, 0, bytes);
                }
                catch(Exception ex)
                {

                }

                //Do something with the command
                if (Command == "SHUTDOWN")
                {
                    //Close the thread's NetStream
                    NetStream.Close();
                    
                    //Remove the client's name from the list, then update the list
                    ListOfServerThreads.Remove("COM_" + (client.RemoteEndPoint as IPEndPoint).Address.ToString());
                    ClearConnetionsListBox();
                    foreach (KeyValuePair<string,ThreadObject> entry in ListOfServerThreads)
                    {
                        UpdateConnectionsListBox(entry.Key.ToString());
                    }

                    //Close the client's socket
                    client.Close();

                    //Close the thread
                    ThreadRunning = false;

                    continue;
                }
                if(Command == "SHUTDOWN_H")
                {
                    //Close the thread's NetStream
                    NetStream.Close();

                    //Remove the client's name from the list, then update the list
                    ListOfServerThreads.Remove("COM_" + (client.RemoteEndPoint as IPEndPoint).Address.ToString());
                    ClearConnetionsListBox();
                    foreach (KeyValuePair<string, ThreadObject> entry in ListOfServerThreads)
                    {
                        UpdateConnectionsListBox(entry.Key.ToString());
                    }

                    //Close the client's socket
                    client.Close();

                    //Close the thread
                    ThreadRunning = false;

                    //Since the host is leaving, shut down the server
                    ShutdownServer();

                    continue;
                }
                
                //Display the command in the command list box
                string buttonPressed = string.Empty;
                string buttonLetter = string.Empty;

                try
                {
                    buttonPressed = CommandDataObject.Instance.DecodeUIDFromMessage(Command);
                    buttonLetter = CommandDataObject.Instance.DecodeMessageFromUID(Command);
                    Command = ((client.RemoteEndPoint) as IPEndPoint).Address.ToString() + ">>>" + Command;
                    UpdateCommandsListBox(Command);
                }
                catch(Exception ex)
                {

                }
                
            }
        }

        private delegate void ShutdownServerDel();
        private void ShutdownServer()
        {
            if(this.InvokeRequired)
            {
                ShutdownServerDel ServerDel = new ShutdownServerDel(ShutdownServer);
                this.Invoke(ServerDel);
            }
            else
            {
                bCommandListener = false;
                tcpListener.Stop();
                Close();
            }
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
