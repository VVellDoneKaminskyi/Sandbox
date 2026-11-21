while (true)
{
    Console.WriteLine("Wpisz wysokość trójkąta prostokątnego, 0 -wyjście z programu: ");
    int x = Convert.ToInt16(Console.ReadLine());
    if (x == 0) break;
    for (int i = 1; i <=x ; i++)
    {
        for (int j = 0; j < i; j++) Console.Write("*");
        Console.Write("\n");
    }
}
