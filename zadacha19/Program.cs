// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
{
    if (number.ToString()[0] == number.ToString()[4] && number.ToString()[1] == number.ToString()[3])
         Console.WriteLine ($"Число {number} является палиндромом");
    else Console.WriteLine ($"Число {number} не является палиндромом");
}
else Console.WriteLine ($"Число {number} не является пятизначным, введите другое число.");