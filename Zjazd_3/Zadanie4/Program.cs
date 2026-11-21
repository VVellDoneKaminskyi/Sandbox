while (true)
{
    Console.WriteLine("Wpisz liczbe, 0 prowadzi do wyjścia z programu: ");
    int x=Convert.ToInt32(Console.ReadLine());
    int n = 0, p = 0;
    if (x == 0) break;
    for(int i = 1; i < x; i++)
    {
        if (Convert.ToBoolean(i % 2)) n++; else p++;
    }
    Console.WriteLine($"Liczb parzystych: {p}\nLiczb nieparzystych{n}");

}
