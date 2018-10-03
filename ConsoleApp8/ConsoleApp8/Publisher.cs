namespace ConsoleApp8
{
    public class Publisher
    {
        public Publisher() { }
        public void Send(PubSubServer server, Message msg)
        {
            server.buffer.Enqueue(msg);
        }
    }
}
