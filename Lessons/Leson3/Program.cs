/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число");
string firstNumber = Console.ReadLine();
Console.WriteLine("Введите второе число");
string secondNumber = Console.ReadLine();
Console.WriteLine("Введите третье число");
string thirdNumber = Console.ReadLine();

int a = int.Parse(firstNumber);
int b = int.Parse(secondNumber);
int c = int.Parse(thirdNumber);

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"Максимальное {max}");
