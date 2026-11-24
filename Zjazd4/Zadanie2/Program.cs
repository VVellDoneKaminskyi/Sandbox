while (true)
{
    Console.WriteLine("Wpisz liczbe: ");
    int x;
    if (int.TryParse(Console.ReadLine(), out x))
    {
        if (x == 0) break;
        int sum = 0, ilosc = 0;
        do
        {
            sum += x % 10;
            ilosc++;
            x = x / 10;
        } while (x >= 1);
        Console.WriteLine($"Cyfr jest {ilosc}\n Summa cyfr: {sum}");
    }
    else
    {
        Console.WriteLine("Wpisano text albo nieprawidłową liczbę.");
    }
}
