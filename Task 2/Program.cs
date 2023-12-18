//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = { 2, 5, 8, 12, 15, 18, 21, 24, 27, 30 };
int evenCount = 0;

foreach (int element in array)
{
    if (element % 2 == 0)
    {
        evenCount++;
    }
}

Console.WriteLine($"Number of even elements in the array: {evenCount}");