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
using CommLib;

namespace Login
{
    public partial class LoginForm : Form
    {
        private TcpClient ClientConnection = null;
        private NetworkStream CommandStream = null;

        bool isHost = false;

        //Can't have data client and stream until CommLib is properly hooked up

        public LoginForm()
        {
            InitializeComponent();

            //Fill in the h_ServerIPAddress textbox with the computer's IP Address
            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            ServerIPAddress.Text = IPHost.AddressList[0].ToString();

            //Set the error labels to be invisible
            errorLabel.Visible = false;
            h_errorLabel.Visible = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Byte[] data = new Byte[1024];
            //data = Encoding.ASCII.GetBytes("LOGIN");
            //CommandStream.Write(data, 0, data.GetLength(0));
            errorLabel.Visible = false;

            try
            {
                Client.GameClient c = new Client.GameClient(ServerIPAddress.Text, PortNumber.Text);
                if (c.isConnected == true)
                {
                    c.Show();
                    this.Hide();
                }
                else
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Failed to Connect";
                    c = null;
                }
            }
            catch(Exception ex)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Failed to Connect";
            }
        }

        private void HostButton_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());

                //Make a new server
                Server.ServerForm s = new Server.ServerForm(true);
                isHost = true;
                s.Show();

                //Make and show the game client
                Client.GameClient c = new Client.GameClient(IPHost.AddressList[0].ToString(), PortNumber.Text);
                c.m_IsHost = true;
                c.Show();

                this.Hide();
            }
            catch(Exception ex)
            {
                h_errorLabel.Visible = true;
                h_errorLabel.Text = "Failed to Start Game";
            }
        }    
    }
}
