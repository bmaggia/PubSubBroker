﻿using System;
using Subscriber.Commands;

namespace Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = "";

            TCP_Connection tcpConnection = new TCP_Connection();
            bool connected = tcpConnection.ConnectTCP();

            if (connected)
            {
                Console.WriteLine(@"Connected to server. Type ""Help"" for a list of commands.");
            }

            while (userInput != "quit" && connected)
            {
                userInput = Console.ReadLine().ToLower();

                if (userInput == "help")
                {
                    Console.WriteLine("Commands: \n" +
                        "Subscribe" +
                        "Unsubscribe" +
                        "Query Topics");

                }
                else if (userInput == "subscribe")
                {
                    Subscription.NewSubscription();
                }
                else if (userInput == "unsubscribe")
                {
                    Subscription.RemoveSubscription();
                }
                else if (userInput == "query topics")
                {
                    QueryTopics.Query();
                }

            }
        }
    }
}
