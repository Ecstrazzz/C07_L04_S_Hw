// Знакомство с языками программирования (семинары)

// Урок 4. Функции

// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа завершается
// при вводе символа ‘q’ или при вводе числа, сумма цифр
// которого чётная.

// Пример:
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

// Решение:

// while (true)
// {
//     Console.WriteLine("Введите целое число ('q' для выхода)");
//     string userData = Console.ReadLine();

//     if (userData == "q")
//     {
//         Console.WriteLine("Завершение");
//         break;
//     }
//     int num = Convert.ToInt32(userData);
//     int temp = num;
//     int sum = 0;
//     while (temp > 0)
//     {
//         sum += temp % 10;
//         temp /= 10;
//     }
//     if (sum % 2 == 0)
//     {
//         Console.WriteLine("Завершение");
//         break;
//     }
// }

//--------------------------------------------------

// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу, которая
// покажет количество чётных чисел в массиве.

// Пример: [344 452 341 125] => 2

// Решение:

Console.WriteLine("Введите количество чисел");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];

void ArrayGen() //Заполнение массива случайными трёхзначными числами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

int GetNumber() // Количество чётных чисел в массиве
{
    int countNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countNumber++;
        }
    }
    return countNumber;
}

void PrintArray() // Форматированный вывод чисел массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == count - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + " ");
        }
    }
    Console.Write("]");
}

ArrayGen();
PrintArray();
Console.Write(" => " + GetNumber());