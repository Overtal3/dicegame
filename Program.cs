namespace dicegame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommna till Tärningsspelet");
            Console.WriteLine("Skriv Börja för att börja");
            Random rand = new Random();
            int randomnumber = rand.Next(1, 7);
            int playertotal = 0;
            int dealertotal = 0;
            string answer = "zutt";
            int finish = 0;
            int pfinish = 0;
            string Start = (Console.ReadLine());
            if (Start == "Börja" || Start == "börja" || Start == "Start" || Start == "start")
            {
                Console.WriteLine("Vill du slå eller stanna?");
                while (finish!=2)
                {
                    while (pfinish == 0)
                    {
                        answer = (Console.ReadLine());
                        if (answer == "slå")
                        {
                            randomnumber = rand.Next(1, 7);
                            playertotal += randomnumber;
                            Console.WriteLine("du fick " + randomnumber + ". din total är " + playertotal);
                            pfinish++;
                        }
                        else if (answer == "stanna")
                        {
                            Console.WriteLine("du har valt att stanna");
                            pfinish++;
                            finish++;
                        }
                    }
                    pfinish = 0;
                    if (dealertotal < 16)
                    {
                        randomnumber = rand.Next(1, 7);
                        dealertotal += randomnumber;
                        Console.WriteLine("dealern fick " + randomnumber + ". dealerns total är " + dealertotal);
                    }
                    else
                    {
                        Console.WriteLine("dealern har valt att stanna");    
                    }
                    finish = 0;
                }
                if(playertotal < 21)
                {
                    Console.WriteLine("Du förlorade, too bad so sad");
                }
            }
        }
    }
}
