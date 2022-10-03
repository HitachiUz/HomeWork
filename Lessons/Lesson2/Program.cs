/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Первое число");
string firstNumber = Console.ReadLine();
Console.WriteLine("Второе число");
string secondNumber = Console.ReadLine();

int firstNum = int.Parse(firstNumber);
int secondNum = int.Parse(secondNumber);

if (firstNum >= secondNum)

    Console.WriteLine($"Число {firstNum} больше {secondNum}");
else
    Console.WriteLine($"Число {firstNum} меньше {secondNum}");
