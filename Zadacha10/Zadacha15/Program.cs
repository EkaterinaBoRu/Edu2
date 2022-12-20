// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine()!);


string Weekend(int n)
{
    if (n>5 && n<8)
    {
       return "Выходной день"; 
    }
    else if (n>0 && n<6)
    {
       return "Не является выходным днем"; 
    }
    else return "Нет такого дня недели";
}

string result = Weekend(number);
Console.WriteLine($"Вывод: {result}");
