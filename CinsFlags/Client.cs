using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace CinsFlags
{
    public class Client : TcpConnection

    {
        //Singleton pattern
        private Client()
        {
            client = new TcpClient();
        }
        /// <summary>
        /// Generated 1 client instance
        /// </summary>
        /// <returns>
        /// Client instance
        /// </returns>
        public static Client Instance
        {
            get
            {
                if (instance == null)
                    instance = new Client();
                return (Client)instance;
            }
        }
        /// <summary>
        /// Tries to connect to server
        /// </summary>
        public override async void Connect()
        {
            SendLog("Connecting to server...");           

            //keep trying until connection established
            while (!client.Connected)
            {
                try
                {
                    await client.ConnectAsync(GameInfo.serverIP, Port);                    
                }
                catch (Exception)
                {
                    SendLog("Server connection error");
                    SendLog("Retrying...");
                    await Task.Delay(1000);
                    continue;
                }
            }
            SendLog("Server Connected !");
            //send info to server
            await Write(GameInfo.playerName + " joined the game\r\n");
            await Write("Begin shooting...");
            //start reading
            Read();
        }
    }
}