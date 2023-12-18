//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
double[] array = { 12.34, 56.78, 23.45, 78.90, 45.67, 89.12, 34.56, 67.89, 21.43, 76.54 };
double max = array[0];
double min = array[0];

foreach (double element in array)
{
    if (element > max)
        max = element;

    if (element < min)
        min = element;
}

double difference = max - min;
Console.WriteLine($"Difference between the maximum and minimum elements: {difference}");
