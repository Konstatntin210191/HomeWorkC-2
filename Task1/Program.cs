// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number / 10;
int result2 = result % 10;

Console.WriteLine("Вторая цифра трехзначного числа: ");
Console.WriteLine(result2);
