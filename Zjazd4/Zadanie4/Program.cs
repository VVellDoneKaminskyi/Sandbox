while (true)
{
    Console.Write("Wpisz pierwszą liczbę \"x\", (wpisanie symbolu powoduje wyjście z programu): ");
    if (float.TryParse(Console.ReadLine(), out float x))
    {
        Console.Write("\nWpisz drugą liczbę \"y\", (wpisanie symbolu powoduje wyjście z programu): ");
        if (float.TryParse(Console.ReadLine(), out float y))
        {
            Console.Write($" \n1. {x} + {y} \n2. {x} - {y}  \n3. {x} x {y} \n4. {x} : {y}\nWybierz operacje: ");
            if(int.TryParse(Console.ReadLine(), out int temp))
            {
                switch (temp)
                {
                    case (1): 
                        Console.WriteLine($"{x} + {y} = {x + y}");
                        break;
                    case (2):
                        Console.WriteLine($"{x} - {y} = {x - y}");
                        break;
                    case (3):
                        Console.WriteLine($"{x} x {y} = {x * y}");
                        break;
                    case (4):
                        if(y>0)Console.WriteLine($"{x} : {y} = {x / y}");
                        else Console.WriteLine("Nie można dzielić przez 0!");
                        break;
                    default:
                        Console.WriteLine("Nie prawidłowa opcja!");
                        break;
                }
            } else
            {
                Console.WriteLine("Wpisano nie prawidłową opcje");
                continue;
            }
        }
        else break;
    } else break;
}
