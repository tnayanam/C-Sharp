using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    public class Subscriber
    {
        public string[] topics = new string[2];
        public Queue<Message> myMessage = new Queue<Message>();
        public void Listen(string topic, int index)
        {
            topics[index] = topic;
        }

        public void Print()
        {
            for (int i = 0; i < topics.Length; i++)
            {
                while (myMessage.Count != 0)
                {
                    Message newMessage = myMessage.Dequeue();
                    Console.WriteLine("Topic: " + newMessage.topic + "\n" + newMessage.payload);
                }
            }
        }
    }
}
