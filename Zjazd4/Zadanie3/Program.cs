while (true)
{
    int x = 0;
    Console.WriteLine("Wpisz liczbę, wpiszanie zera powodujewyjście z programu: ");
    if (int.TryParse(Console.ReadLine(), out x))
    {
        if (x == 0) break;
        int temp = 0;
        while (x > 0)
        {
            if (x % 10 == 0)
                temp *= 10;
            else
                temp = temp * 10 + x % 10;
            x = x / 10;
        }
        Console.WriteLine($"Odwrucona liczba to : {temp}");
    }
    else Console.WriteLine("Wprowadzono nieprawidłową liczbę albo text. Spróbuj ponownie!");
    
}
