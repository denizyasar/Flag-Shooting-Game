using System.Drawing;
using System.Windows.Forms;

namespace CinsFlags
{
    public partial class frmMain : Form
    {
        //keep frmInit in variable to show when new game chosen
        public Form frmInitReference { get; set; }

        private delegate void SetTextCallback(string text);

        TcpConnection tcpConnection;

        public frmMain()
        {
            InitializeComponent();
            //fill toolstrip info
            tslServerAddress.Text += GameInfo.serverIP.ToString();
            tslPlayerName.Text += GameInfo.playerName;
            tslMode.Text += GameInfo.mode.ToString();
            tslPort.Text += Server.Port;

            AddLog("Log:");
            AddLog("Please add 5 flags !");

            //for getting events to form when data received
            TcpConnection.OnDataReceived += TcpConnection_OnDataReceived;
            if (GameInfo.mode == Modes.Server)
                tcpConnection = Server.Instance;
            if (GameInfo.mode == Modes.Client)
                tcpConnection = Client.Instance;

        }

        private void TcpConnection_OnDataReceived(object sender, DataReceivedEventArgs e)
        {
            AddLog(e.Message);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void picboxAvrupa_MouseClick(object sender, MouseEventArgs e)
        {
            //check flag count if less add else send the hit point to opponent
            if (Flag.FlagList.Count < 5)
            {
                //create new flag and add it to picturebox
                Flag flag = new Flag(e.X, e.Y);
                flag.DrawArea((PictureBox)sender);

                if (Flag.FlagList.Count != 5)
                    AddLog("Please add " + (5 - Flag.FlagList.Count) + " flags !");
                else
                    tcpConnection.Connect();//after locating 5 flags
            }
            else if (Flag.FlagList.Count == 5)
                await tcpConnection.Write(e.X.ToString() + "," + e.Y.ToString());
        }

        private void tsbtnColorChoser_Click(object sender, System.EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
                Flag.AreaColor = colorDialog.Color;

            picboxAvrupa_Paint(sender, null);
        }
        //check if the textbox available-not in use by another process
        private void AddLog(string text)
        {
            if (this.txtLog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddLog);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtLog.AppendText(text + "\r\n");
            }
        }

        private void tsbtnNewGame_Click(object sender, System.EventArgs e)
        {
            this.Dispose(false);
            Flag.Reset();
            tcpConnection.Dispose();
            this.frmInitReference.Show();

        }

        private void picboxAvrupa_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = picboxAvrupa.CreateGraphics();

            foreach (Rectangle f in Flag.FlagList)
            {
                Brush brush = new SolidBrush(Flag.AreaColor);
                g.FillRectangle(brush, f);
                g.DrawImage(Properties.Resources.flag, f.X + 1, f.Y - 11, 20, 20);
            }

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            tcpConnection.Dispose();
        }
    }
}
