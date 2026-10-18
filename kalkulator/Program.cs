string imie;
decimal x,y,z,result;
Console.WriteLine("Witamy w kalkuratorze ocen. Podaj swoje Imię: ");
imie = Console.ReadLine();
Console.WriteLine("Wpisz 3 oceny");
Console.WriteLine("Pierwsza: ");
x = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Druga: ");
y = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Trecza: ");
z = Convert.ToDecimal(Console.ReadLine());
result = (x+y+z)/3;
if(result >= 3)
{
Console.Write(imie); Console.Write(" , Twoja średnia to: "); Console.WriteLine (Math.Round(result,1));
} else {
    Console.WriteLine("Nie zdałeś.");
}