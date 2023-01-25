// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.Write("Напишите пятизначное число -> ");
String number = Console.ReadLine();
int pal = number.Length;

if (pal == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine($"{number} -- Палидром. ");
    }
    else
    {
        System.Console.WriteLine("Это число не палидром.");

    }
}
else
{
    System.Console.WriteLine("Это не пятизначное число.");
}