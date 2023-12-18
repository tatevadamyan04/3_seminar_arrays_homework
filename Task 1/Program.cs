//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = { 15, 25, 30, 40, 50, 60, 70, 80, 91, 100 };

int count = 0;

foreach (int element in array)
{
    if (element >= 20 && element <= 90)
    {
        count++;
    }
}

Console.WriteLine($"Number of elements in the range [20, 90]: {count}");
