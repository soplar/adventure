using System;


namespace Adventure
{
    class Program
    {
        static void Main()
        {
            int Action;
	        Console.WriteLine("Je staat opeens in een oerwoud, links van je zie je een grot en rechts staat een boomhuis met een deur....");
	        Console.WriteLine("Waar wil je heen?");
            Console.WriteLine("1: Grot");
	        Console.WriteLine("2: Boomhuis");
	        Action = int.Parse(Console.ReadLine());

            switch (Action)
            {
                case 1:
                    Grot();
                    break;
                case 2:
                    Boomhuis();
                    break;
                default:
                    Console.WriteLine("Geen optie");
                    break;
            }
        }

        static void Grot()
        {
            Console.WriteLine("Je staat nu voor de grot");
        }

        static void Boomhuis()
        {
            Console.WriteLine("Je staat nu voor een deur bij het boomhuis");
        }
    }
}
