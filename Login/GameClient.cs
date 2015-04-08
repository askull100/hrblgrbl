using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Client
{
    public partial class GameClient : Form
    {
        private TcpClient ClientConnection = null;
        private NetworkStream CommandStream = null;

        private Thread ClientThread = null;
        bool isRunning = false;

        public string m_ServerAddress;
        public int m_PortNumber = 8080;
        public bool isConnected = false;

        public GameClient()
        {
            InitializeComponent();
            try
            {
                //COMMAND CONNECTION
                //open the connection to the command port
                IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
                m_ServerAddress = IPHost.AddressList[0].ToString();

                ClientConnection = new TcpClient(m_ServerAddress,
                                    Convert.ToInt32(m_PortNumber.ToString()));

                //Get the command stream
                CommandStream = ClientConnection.GetStream();

                if (CommandStream != null)
                {
                    isConnected = true;
                    ClientThread = new Thread(Receive);
                    isRunning = true;
                    ClientThread.Start();
                }

                errorLabel.Visible = false;
            }
            catch (Exception ex)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Failed to Connect";
            }
        }
        public GameClient(string address, string port)
        {
            InitializeComponent();
            try
            {
                //COMMAND CONNECTION
                //open the connection to the command port
                ClientConnection = new TcpClient(address,
                                    Convert.ToInt32(port));

                //Get the command stream
                CommandStream = ClientConnection.GetStream();
                errorLabel.Visible = false;
            }
            catch (Exception ex)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Failed to Connect";
            }
        }

        private void Receive()
        {
            Byte[] data = new Byte[1024];
            string message = string.Empty;
            while (isRunning == true)
            {
                int BytesReceived = CommandStream.Read(data, 0, 1024);
                message = Encoding.ASCII.GetString(data, 0, BytesReceived);
                //Parse(message);
            }
        }

        private void SlotSelected(int slotNumber)
        {
            //Handle player input here
            //Check if its your turn and if you can even place your token there
            //Don't forget, game /logic/ is processed on the server

            //If the move is valid, create a string to send
            Byte[] command = new Byte[1024];
            string commandStr ="ERROR";
            switch(slotNumber)
            {
                case 1:
                    commandStr = "1:" + gameButton1.Text;
                    break;
                case 2:
                    commandStr = "2:" + gameButton2.Text;
                    break;
                case 3:
                    commandStr = "3:" + gameButton3.Text;
                    break;
                case 4:
                    commandStr = "4:" + gameButton4.Text;
                    break;
                case 5:
                    commandStr = "5:" + gameButton5.Text;
                    break;
                case 6:
                    commandStr = "6:" + gameButton6.Text;
                    break;
                case 7:
                    commandStr = "7:" + gameButton7.Text;
                    break;
                case 8:
                    commandStr = "8:" + gameButton8.Text;
                    break;
                case 9:
                    commandStr = "9:" + gameButton9.Text;
                    break;
            }
            
            //Encode and send the string
            command = Encoding.ASCII.GetBytes(commandStr);
            CommandStream.Write(command, 0, command.GetLength(0));
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //Ask player if he wants to forfeit the match
            //Do logout logic here
        }

        private void gameButton1_Click(object sender, EventArgs e)
        {
            SlotSelected(1);
        }

        private void gameButton2_Click(object sender, EventArgs e)
        {
            SlotSelected(2);
        }

        private void gameButton3_Click(object sender, EventArgs e)
        {
            SlotSelected(3);
        }

        private void gameButton4_Click(object sender, EventArgs e)
        {
            SlotSelected(4);
        }

        private void gameButton5_Click(object sender, EventArgs e)
        {
            SlotSelected(5);
        }

        private void gameButton6_Click(object sender, EventArgs e)
        {
            SlotSelected(6);
        }

        private void gameButton7_Click(object sender, EventArgs e)
        {
            SlotSelected(7);
        }

        private void gameButton8_Click(object sender, EventArgs e)
        {
            SlotSelected(8);
        }

        private void gameButton9_Click(object sender, EventArgs e)
        {
            SlotSelected(9);
        }
    }
}
