namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher dogPublisher = new Publisher(); // this is sending request about dog stuff
            Publisher catPublisher = new Publisher(); // this is sending request about cat stuff
            PubSubServer server = new PubSubServer();
            Subscriber animalLover = new Subscriber(); // wants to subscribe to all messages from publisher
            Subscriber catLover = new Subscriber(); // wants to subscribe to cat related message from publisher
            // animal lover wants to know about both publisher
            // cat lover wants to know only sbout catPublisher
            Message dogMessage = new Message { payload = "This is dog paylod", topic = "Dogs" };
            Message catMessage = new Message { payload = "This is cat paylod", topic = "Cats" };
            dogPublisher.Send(server, dogMessage); // all these messages are getting enqueued in the server
            catPublisher.Send(server, catMessage); // all these messages are getting enqueued in the server
            server.subscribers[0] = animalLover;
            server.subscribers[1] = catLover;
            // Now here we will tell which publisher is interested in which type of subscriber
            animalLover.Listen("Dogs", 0);
            animalLover.Listen("Cats", 1);
            // cat lover is only interested in cats topic
            catLover.Listen("Cats", 0);
            server.Forward();
            animalLover.Print();
            catLover.Print();
        }
    }
}

/*
 * OUTPUT---
 * Topic: Dogs
This is dog paylod
Topic: Cats
This is cat paylod
Topic: Cats
This is cat paylod
Press any key to continue . . .
 *
 */
