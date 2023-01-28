// See Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число-a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число-b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число-b: ");
int numberC = Convert.ToInt32(Console.ReadLine());

numbers = [int numberA, int numberB, int numberC];
size = 3;
current_index = 0;
max_number_index = 0;
int max = 0;

while (current_index < size) do
if (numbers{current_index} > max) then max = numbers{current_index}
max_number_index = current_index
current_index = current_index + 1;

