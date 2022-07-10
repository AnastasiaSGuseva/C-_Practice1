//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine ("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine ());
int M = 2;

while (M <= N)
{
    Console.Write (M);
    Console.Write (" ");
    M = M + 2;
}