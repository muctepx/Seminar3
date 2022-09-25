/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNumber()
{
    Console.WriteLine("Введите пятизначное число: ");
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr ?? "");
    return number;
}

int number = GetNumber();

if (number < 100000 && number > 9999)
{
    if (number/10000 == number%10 && (number/1000)%10 == (number/10)%10)
    Console.WriteLine("да");
    else
    Console.WriteLine ("нет");
}
else
Console.WriteLine ("Вы ввели не пятизначное число");