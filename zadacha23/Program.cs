//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (n<= 0) Console.Write("Введите число (N) больше 0.");
else if (n>1)
{
    Console.Write($"Все значения чисел от 1 до {n} в кубе -> ");
    while (n>count)
    {
        Console.Write($"{Math.Pow(count, 3)}, ");
        count++;
    }
    Console.Write(Math.Pow(count, 3) + ".");
}
else if (n == 1) Console.Write("В диапозоне только одно число - '1', куб которого равен 1.");
