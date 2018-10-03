using System.Collections.Generic;
namespace ConsoleApp8
{
    public class PubSubServer
    {
        public Queue<Message> buffer = new Queue<Message>();
        public Subscriber[] subscribers = new Subscriber[2];
        public void Forward()
        {
            // send the buffer to all subscribers
            while (buffer.Count != 0)
            {
                var temp = buffer.Dequeue();
                for (int i = 0; i < subscribers.Length; i++)
                {
                    for (int j = 0; j < subscribers[i].topics.Length; j++)
                    {
                        if (temp.topic == subscribers[i].topics[j])
                        {
                            subscribers[i].myMessage.Enqueue(temp);
                        }
                    }
                }
            }
        }
    }
}
