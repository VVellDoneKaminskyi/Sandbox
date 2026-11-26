while (true)
{
    Console.Write("\nWpisz liczbę (\"0\" powoduje wyjście z programu): ");
    if (int.TryParse(Console.ReadLine(), out int x))
    {
        if (x == 0) break;
        if(x>0)for (int i = 1; i <= x; i++)
        {
            Console.WriteLine($"{i} - kwadrat: {i * i}");
        }else for(int i = 1; i >= x; i--)
        {
            Console.WriteLine($"{i} - kwadrat {i * i}");
        }
    }
    else
    {
        Console.Write("\nWpisano text, lub nie całkowitą liczbę! Spróbuj ponownie.");
        continue;
    }
}
