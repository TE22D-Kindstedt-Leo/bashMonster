using System.Reflection.Metadata.Ecma335;

karaktär theKaraktär = new karaktär();
Fiende theFiende = new Fiende();


Console.WriteLine($"{theKaraktär.namn} har {theKaraktär.hälsa} hälsa");
Console.WriteLine($"{theFiende.namn} har {theFiende.hälsa} hälsa");

Console.WriteLine("ATTACK!");
theFiende.hälsa -= 10;

Console.WriteLine($"{theFiende.namn} har {theFiende.hälsa} hälsa");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();