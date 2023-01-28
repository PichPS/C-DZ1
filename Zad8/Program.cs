// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int A = 1;

while (A <= N)
{
    if(A % 2 == 0);
    {
        Console.WriteLine($"Четные от 1 до {N} {A}");
    }
    A++;
}