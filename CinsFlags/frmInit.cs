using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace CinsFlags
{
    public partial class frmInit : Form
    {
        public frmInit()
        {
            InitializeComponent();
            //fill combobox from Modes enum
            cbMode.DataSource = Enum.GetValues(typeof(Modes));
            //set default to server
            cbMode.SelectedIndex = 0;
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtxtServerAddress.Text = string.Empty;
            if (cbMode.SelectedIndex == (int)Modes.Client)
                mtxtServerAddress.Enabled = true;
            else
                mtxtServerAddress.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            IPAddress serverAddress;
            //if client is chosen check server IP format else for server get local IP
            if (cbMode.SelectedIndex == (int)Modes.Client)
                try
                {
                    serverAddress = IPAddress.Parse(mtxtServerAddress.Text.Replace(" ", ""));
                }
                catch
                {
                    MessageBox.Show(this, "Please enter a valid IP address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            else
                serverAddress = GetLocalIP();
            //check player name
            if (txtPlayerName.Text == string.Empty)
                MessageBox.Show(this, "Please enter a name for the user!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //save data
                GameInfo.playerName = txtPlayerName.Text;
                GameInfo.mode = (Modes)cbMode.SelectedItem;
                GameInfo.serverIP = serverAddress;
                //show main form
                frmMain frmMain = new frmMain();
                frmMain.frmInitReference = this;
                Hide();
                frmMain.Show();
            }
        }

        //find local ip
        private IPAddress GetLocalIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip;
            return IPAddress.Loopback;
        }
    }
}