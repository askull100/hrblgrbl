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

namespace Login
{
    public partial class LoginForm : Form
    {
        private TcpClient CommandConnection = null;
        private NetworkStream CommandStream = null;

        private TcpClient DataConnection = null;
        private NetworkStream DataStream = null;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            //COMMAND CONNECTION
            //Open Connection to the command port
            //CommandConnection = new TcpClient(ServerIPAddress.Text, Convert.ToInt32(PortNumber.Text));
            //Get the command stream
            CommandStream = CommandConnection.GetStream();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Byte[] data = new Byte[1024];
            data = Encoding.ASCII.GetBytes("LOGIN");
            CommandStream.Write(data, 0, data.GetLength(0));
        }
    }
}
