Random random = new Random();
int r = random.Next(1 , 99);
bool e = true;
while (e)
{
    Console.Write("Zgadnij liczbę: ");
    int x = Convert.ToInt16(Console.ReadLine());
    if (x < r)
    {
        Console.WriteLine("Liczba jest zamała, sprubój ponownie!");

    } else if(x > r)
    {
        Console.WriteLine("Liczba jest za duża, sprubój ponownie!");
    } else
    {
        Console.WriteLine("Gratulacje! Koniec gry.");
        e = false;
    }

}
