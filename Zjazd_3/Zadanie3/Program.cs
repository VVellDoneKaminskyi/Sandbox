using System.Net;

while (true)
{
    int x = 0,min = 6,max = 0,pos = 0;
    decimal mid = 0;
    Console.Write("Wpisz ilość wprowadzanych ocen, \"0\" powoduje wyjście: ");
    x = Convert.ToInt16(Console.ReadLine());
    if (x == 0) break;
    for (int i = 0; i < x; i++)
    {
        int t = 0;
        Console.WriteLine($"Wpisz {i + 1} ocenę :");
        t = Convert.ToInt16(Console.ReadLine());
        if (t != 0 && t < 7)
        { 
            if (t > max) max = t;
            if (t < min) min = t;
            if (t >= 3) pos++;
            mid +=t;
        }
        else
                
        {
            Console.WriteLine("Wpisano nie prawidłową ocene, spróbój jeście raz");
            --i;
        }
    }
    Console.WriteLine($"Średnia ocena: {Math.Round(mid / x, 1)} \nNajwyższa ocena: {max}\nNajniższa: {min}\nŁącznie {pos} ocen pozytywnych");
}
