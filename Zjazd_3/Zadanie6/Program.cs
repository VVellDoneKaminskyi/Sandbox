while (true)
{
    Console.WriteLine("Wpisz liczbę: ");
    int x = Convert.ToInt16(Console.ReadLine());
    bool temp = false;
    if (x == 0) break;
    else if (x == 1) Console.WriteLine("Liczba 1 jest liczbą pierwszą");
    else if (x == 2) Console.WriteLine("Liczba 2 jest liczbą pierwszą");
    else if (x == 3) Console.WriteLine("Liczba 3 jest liczbą pierwszą");
    else if (x == 5) Console.WriteLine("Liczba 5 jest liczbą pierwszą");
    else if (x == 7) Console.WriteLine("Liczba 7 jest liczbą pierwszą");
    else if (!Convert.ToBoolean(x % 2) || !Convert.ToBoolean(x % 3) || !Convert.ToBoolean(x % 5) || !Convert.ToBoolean(x % 7)) Console.WriteLine($"Liczba {x} nie jest pierwsza!");
    else Console.WriteLine($"Liczba {x} jest pierwsza !");

}