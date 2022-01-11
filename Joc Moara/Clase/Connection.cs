using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace Joc_Moara
{
    public class Connection
    {
        private TcpListener server = null;
        private TcpClient client = null;
        private NetworkStream stream = null;
        private string adresa = null;
        private byte[] buffer = new byte[4096];
        private string datePrimite = null;
        private IWaitable sender = null;

        //Pentru Server
        public Connection(IConnectable sender)
        {
            Int32 port = 7777;

            IPAddress localAdress = IPAddress.Parse(Dns.GetHostEntry(Dns.GetHostName()).AddressList.First(x => x.AddressFamily.ToString() == "InterNetwork").ToString());
            adresa = localAdress.ToString();
            server = new TcpListener(localAdress, port);

            startServer(sender);
        }

        //Pentru Client
        public Connection(string adresa, IConnectable sender)
        {
            this.adresa = adresa;
            client = new TcpClient();
            startClient(sender);

        }

        async private void startServer(IConnectable sender)
        {
            try
            {
                server.Start();
                client = await server.AcceptTcpClientAsync();
                stream = client.GetStream();
                stream.Flush();
                sender.connected();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        async private void startClient(IConnectable sender)
        {
            try
            {
                await client.ConnectAsync(adresa, (Int32)7777);
                stream = client.GetStream();
                stream.Flush();
                sender.connected();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void disconnectClient()
        {
            if (client != null)
                client.Close();
        }

        public void stopServer()
        {
            server.Stop();
        }

        public string getAdresa()
        {
            return adresa;
        }

        public void waitForPlayer(IWaitable sender)
        {
            buffer = new byte[4096];
            this.sender = sender;
            stream.BeginRead(buffer, 0, buffer.Length, this.answere, null);
        }

        private void answere(IAsyncResult result)
        {
            datePrimite = null;
            datePrimite = Encoding.Default.GetString(buffer, 0, buffer.Length);
            datePrimite = datePrimite.Substring(0,datePrimite.IndexOf(datePrimite.First(x=>x == 0)));
            sender.answere(datePrimite);
            stream.Flush();
        }

        public void sendObject(string send)
        {
            byte[] buffer = Encoding.Default.GetBytes(send);
            stream.Write(buffer, 0, buffer.Length);
        }

    }
}
