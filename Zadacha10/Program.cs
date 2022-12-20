// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

int result = -1;

if ((number/100>=1) && (number/1000==0)) 
{
    result = (number/10)%10;
    Console.WriteLine($"Вторая цифра трехзначного числа: {result}");
}
else Console.WriteLine("Введено нетрехзначное число");

