using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GitBay2.Logic
{
    internal class CommunicationManager : ICommunicationManager
    {
        private ManualResetEvent allDone = new ManualResetEvent(false);

        private IPEndPoint _communicationEndPoint;

        public CommunicationManager(int port) 
        {
            var ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            var ipAddress = ipHostInfo.AddressList[0];
            _communicationEndPoint = new IPEndPoint(ipAddress, port);
        }

        public void Begin()
        {         
            try
            {
                using (var serverSocket = new Socket(_communicationEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp))
                {
                    serverSocket.Bind(_communicationEndPoint);
                    serverSocket.Listen(256);
                    while (true)
                    {
                        allDone.Reset();
#if DEBUG
                        Console.WriteLine("Oczekiwanie na połączenie...");
#endif
                        serverSocket.BeginAccept(new AsyncCallback(OnAccept), serverSocket);
                        allDone.WaitOne();
                    }
                } 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Dispose()
        {

        }

        private void OnAccept(IAsyncResult ar)
        {
            allDone.Set();

            var serverSocket = (Socket)ar.AsyncState;
            var handler = serverSocket.EndAccept(ar);

            var stateObject = new StateObject()
            {
                WorkSocket = handler
            };

            handler.BeginReceive(stateObject.Buffer, 0, StateObject.BufferSize, 0, 
                new AsyncCallback(ReadCallback), stateObject);
        }

        private void ReadCallback(IAsyncResult ar)
        {
            var content = String.Empty;
 
            var state = (StateObject)ar.AsyncState;
            var handler = state.WorkSocket;

            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                state.Sb.Append(Encoding.ASCII.GetString(
                    state.Buffer, 0, bytesRead));
 
                content = state.Sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
#if DEBUG
                    Console.WriteLine("Odczytano {0} bajtów z Socketu. \n Data : {1}",
                        content.Length, content);
#endif
                    Send(handler, content);
                }
                else
                { 
                    handler.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }

        private void Send(Socket handler, String data)
        {  
            byte[] byteData = Encoding.ASCII.GetBytes(data);
 
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {  
                Socket handler = (Socket)ar.AsyncState;
 
                int bytesSent = handler.EndSend(ar);
#if DEBUG
                Console.WriteLine("Wysłano {0} bajtów do klienta.", bytesSent);
#endif

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private class StateObject
        {   
            public const int BufferSize = 1024;
            private byte[] _buffer = new byte[BufferSize];
            private StringBuilder _sb = new StringBuilder();
            public byte[] Buffer { get { return _buffer; } }
            public StringBuilder Sb { get { return _sb; } }
            public Socket WorkSocket { get; set; }
        }
    }
}
