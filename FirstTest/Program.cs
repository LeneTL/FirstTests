
Greetings();
        static void Greetings()
        {
            Console.WriteLine("Hi! What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Well hello, {name}! Lovely to see you here!");
            Console.WriteLine(); //cw
        }