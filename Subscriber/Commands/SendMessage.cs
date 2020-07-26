﻿using Newtonsoft.Json;
using System.Text;

namespace Subscriber.Commands
{
    class SendMessage
    {
        public static void Send(Command command)
        {
            var jsonString = JsonConvert.SerializeObject(command);

            TCP_Connection.TCPNetworkStream.Write(Encoding.ASCII.GetBytes(jsonString));
        }
    }
}
