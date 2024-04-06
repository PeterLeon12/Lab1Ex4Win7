//Ex 4
//Scrieti un program care va afisa semnul unui numar citit de la tastatura
//• Daca numarul este pozitiv, va afisa “+”
//• Daca numarul este negativ, va afisa “-”
//• Daca numarul este 0, va afisa “0
//


Console.WriteLine("Scrieti un numar:");
int numar = int.Parse(Console.ReadLine());

Console.WriteLine("Numarul" + " " + numar + " " + "este ");



if (numar > 0)
{
    Console.WriteLine("+");
}
else if (numar < 0)
{
    Console.WriteLine("-");
}
else
{
    Console.WriteLine("0");
}

