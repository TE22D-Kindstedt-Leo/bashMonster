using System.Reflection.Metadata.Ecma335;

karaktär theKaraktär = new karaktär();
Fiende theFiende = new Fiende();

Console.WriteLine("Välkomen vad heter du");
string namn = Console.ReadLine();

while (theKaraktär.hälsa > 0)
{
    Console.WriteLine("Du ser ett monster");
    Console.WriteLine("Vill du attakera j/n");
    string val = Console.ReadLine();

    if (val == "j")
    {
        while (theKaraktär.hälsa > 0 && theFiende.hälsa > 0)
        {
            Console.Clear();

            Console.WriteLine($"{namn} har {theKaraktär.hälsa} hälsa");
            Console.WriteLine($"{theFiende.namn} har {theFiende.hälsa} hälsa");
            Console.WriteLine();
            
            Console.WriteLine("Vad Vill du göra");
            Console.WriteLine("1. attackera");
            Console.WriteLine("2. spring iväg");
            string alternativ = Console.ReadLine();
            Console.WriteLine();

            if (alternativ == "1")
            {
                Console.WriteLine("ATTACK!");
                theFiende.hälsa -= theKaraktär.attack;
                Console.WriteLine($"{theFiende.namn} har {theFiende.hälsa} hälsa");
                Console.WriteLine();

                Console.WriteLine("Monstret attackarer tillbacka");
                theKaraktär.hälsa -= theFiende.attack;
                Console.WriteLine($"{namn} har {theKaraktär.hälsa} hälsa");
                Console.WriteLine();

                Console.WriteLine("Tryck för att fortsätta");
                Console.ReadKey();
            }

            else if (alternativ == "2")
            {
                Console.WriteLine("Du börjar springa när monstret plötsligt sllår dig i ryggen");
                Console.WriteLine("Du är död");
                theKaraktär.hälsa = 0;
            }
            else
            {
                Console.WriteLine("Jag förstog inte försök igen");
                Console.ReadKey();
            }
        }
    }
    else if (val == "n")
    {
        Console.WriteLine("Du springer iväg din fegis");
        Console.ReadLine();
    }
    else 
    {
        Console.WriteLine("jag förståer inte");
        Console.ReadLine();
    }
}
Console.WriteLine("Spelet är slut");
Console.ReadLine();
