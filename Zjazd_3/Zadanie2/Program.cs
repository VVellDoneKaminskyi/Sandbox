while (true)
{
    int x = 0;
    Console.WriteLine("Podaj liczbę, zero \"0\" powoduje wyjście z programu");
    x=Convert.ToInt16(Console.ReadLine());
    if (x == 0) break;
    for(int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{i} x {x} = {i*x}");
    }

}
