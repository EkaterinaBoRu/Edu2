// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int digit_3 = -1;

int CountDigit(int n)
{
    int count = 1;
    while (n/10>=1)
    {
        n = n/10;
        count ++;
    }
    return count;
}
int digit_number = CountDigit(number);
//Console.WriteLine($"всего разрядов: {digit_number}");

if (digit_number >= 3)
{
    while (digit_number > 3)
{
        number = number/10;
        digit_number = digit_number -1;
}
    digit_3 = number%10;
    Console.WriteLine($"Третья цифра числа: {digit_3}");
}
else Console.WriteLine("Нет третьей цифры в числе");

