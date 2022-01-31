using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CinsFlags
{
    public abstract class TcpConnection : IDisposable
    {
        public static int Port { get; } = 9100;

        public static event EventHandler<DataReceivedEventArgs> OnDataReceived;
        protected TcpClient client { get; set; }

        protected static TcpConnection instance = null;

        protected void SendLog(string text)
        {
            OnDataReceived.Invoke(this, new DataReceivedEventArgs(text));
        }

        //send message to opponent asynchronously
        public async Task Write(string message)
        {
            if (!(client is null))
            {
                var stream = client.GetStream();
                byte[] msg = Encoding.ASCII.GetBytes(message);
                await stream.WriteAsync(msg, 0, msg.Length);
            }
        }

        //read incoming messages asynchronously
        protected async Task Read()
        {
            var buffer = new byte[1024];
            var ns = client.GetStream();

            var bytesAvailable = await ns.ReadAsync(buffer, 0, buffer.Length);
            string msg = Encoding.ASCII.GetString(buffer, 0, bytesAvailable).Trim('\0');
            if (Regex.IsMatch(msg, @"^\d"))
            {
                int x = int.Parse(msg.Split(',')[0]);
                int y = int.Parse(msg.Split(',')[1]);
                //check every rectangle in list for shoot result
                foreach (Rectangle r in Flag.FlagList)
                {
                    if (r.Left + 7 == x && r.Top + 7 == y)//center of rectangle
                        Write("You hit the flag");
                    else if (r.Contains(x, y))
                        Write("You hit the region");
                }
            }
            else {
                //if the connection drops create new listener or connect to listener
                if (msg == string.Empty)
                {
                    Dispose();
                    Connect();
                }
                else
                    SendLog(msg);//rise event to send msg to form
            }
            //loop listenning
            Read();
        }

        public abstract void Connect();

        public virtual void Dispose()
        {
            if (!(client is null))
                client.Close();
            instance = null;           
        }
    }

    public class DataReceivedEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public DataReceivedEventArgs(string message)
        {
            Message = message;
        }
    }

}