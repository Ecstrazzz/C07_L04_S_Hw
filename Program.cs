// Знакомство с языками программирования (семинары)

// Урок 4. Функции

// Задача 1: Напишите программу, которая бесконечно запрашивает
// целые числа с консоли. Программа завершается при вводе
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// Решение:

while (true)
{
    Console.WriteLine("Введите целое число ('q' для выхода)");
    string userData = Console.ReadLine();

    if (userData == "q")
    {
        Console.WriteLine("Завершение");
        break;
    }
    int num = Convert.ToInt32(userData);
    int temp = num;
    int sum = 0;
    while (temp > 0)
    {
        sum += temp % 10;
        temp /= 10;
    }
    if (sum % 2 == 0)
    {
        Console.WriteLine("Завершение");
        break;
    }
}
