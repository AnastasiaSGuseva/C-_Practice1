//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine ("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine ());

if (N % 2 == 1)
{
    N = N - 1;
    while (N >= 2)
{
    Console.Write (N);
    Console.Write (" ");
    N = N - 2;
}
}

else
{
while (N > 2)
{
    N = N - 2;
    Console.Write (N);
    Console.Write (" ");
}
}
