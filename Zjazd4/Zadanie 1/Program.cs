while (true)
{
    Console.WriteLine("\nWpisz liczbę: ");
    int x = int.Parse(Console.ReadLine());
    if (x == 0) break;
    Console.Write("Podzielne przez 3: ");
    for (int i = 1; i < x; i++)
    {
        if (!Convert.ToBoolean(i % 3)) Console.Write($"{i} ");
    }
    Console.Write("\nPodzielna przez 5: ");
    for (int i = 1;i < x; i++)
    {
        if (!Convert.ToBoolean(i % 3)) Console.Write($"{i} ");
    }
    Console.Write("\nPodzielne przez 3 i 5: ");
    for (int i = 1; i < x ; i++)
    {
        if(!Convert.ToBoolean(i % 15))
        {
            Console.Write($"{i} ");
        }
    }
}
