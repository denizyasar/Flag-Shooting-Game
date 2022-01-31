using System;
using System.Net.Sockets;


namespace CinsFlags
{
    //Singleton pattern
    public class Server : TcpConnection
    {    
        //helper class listener object
        public TcpListener listener { get; }

        private Server()
        {
            listener = new TcpListener(GameInfo.serverIP, Port);
        }

        //start listener and begin to wait for connection
        //then start reading
        public override async void Connect()
        {
            listener.Start();
            SendLog("Waiting for opponent...");
            try
            {
                client = await listener.AcceptTcpClientAsync();
            }
            catch (Exception)
            {
                return;
            }

            await Write("Begin shooting...");
            Read();           
        }

        //singleton instance access
        public static Server Instance
        {
            get
            {
                if (instance == null)
                    instance = new Server();
                return (Server)instance;
            }
        }

        public override void Dispose()
        {
            base.Dispose();
            listener.Stop();
        }
    }
}