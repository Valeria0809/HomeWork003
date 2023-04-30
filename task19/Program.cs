// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string? num = Console.ReadLine();
int i = num!.Length;
if(i == 5)
{
    if(num[0] == num[4] && num[1] == num[3])
    {
        System.Console.WriteLine($"{num} - палиндром ");
    }
    else
    {
        System.Console.WriteLine($"{num} - НЕ палиндром ");
    }
}
else
{
    System.Console.WriteLine($"ОШИБКА!!!: {num} - Не является пятизначным числом ");
}