﻿using System;
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
//using CommLib;

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
            h_ServerIPAddress.Text = IPHost.AddressList[0].ToString();

            //Set the error labels to be invisible
            errorLabel.Visible = false;
            h_errorLabel.Visible = false;

        }

        //private void ConnectButton_Click(object sender, EventArgs e)
        //{
        //    //COMMAND CONNECTION
        //    //Open Connection to the command port
        //    //CommandConnection = new TcpClient(ServerIPAddress.Text, Convert.ToInt32(PortNumber.Text));
        //    //Get the command stream
        //    //CommandStream = CommandConnection.GetStream();
        //}

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Byte[] data = new Byte[1024];
            //data = Encoding.ASCII.GetBytes("LOGIN");
            //CommandStream.Write(data, 0, data.GetLength(0));

            try
            {
                //COMMAND CONNECTION
                //open the connection to the command port
                ClientConnection = new TcpClient(ServerIPAddress.Text,
                                    Convert.ToInt32(PortNumber.Text));

                //Get the command stream
                CommandStream = ClientConnection.GetStream();
            }
            catch(Exception ex)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Failed to Connect";
            }
        }

        private void HostButton_Click(object sender, EventArgs e)
        {
            isHost = true;
            //figure out how to close login form and open server form.
            //try converting bool to string, then sending that over via message
            //need commlib functionality to do so godammit
        }

        private void passwordOn_CheckedChanged(object sender, EventArgs e)
        {
            if(passwordOn.Checked == false)
            {
                h_passwordTextBox.Enabled = false;
            }
            else
            {
                h_passwordTextBox.Enabled = true;
            }
        }

        
    }
}
