Console.WriteLine("Wpisz dowolną liczbę naturalną i dowiesz się summe wszystkich liczb naturalnych przed nią, łącznie z nią");
Console.WriteLine("Wprowadzenie liczby 0 wywoła wyjście z programu");

while (true)
{
    int x = 0; 
    Console.WriteLine("Wpisz liczbę:");
    x = Convert.ToInt32(Console.ReadLine());
    if (x == 0) break;
    else
    {
        int result = 0;
        for (int i = 0; i <= x; i++) result = result + i;
        Console.WriteLine($"Summa jest {result}");
    }

}