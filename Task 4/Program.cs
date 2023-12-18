//Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

Console.WriteLine("Enter a natural number between 1 and 100,000:");
int userInput = Convert.ToInt32(Console.ReadLine());
if (userInput >= 1 && userInput <= 100000)
{
    int numDigits = 0;
    int temp = userInput;
    while (temp > 0)
    {
        temp /= 10;
        numDigits++;
    }

    int[] digitArray = new int[numDigits];

    for (int i = numDigits - 1; i >= 0; i--)
    {
        digitArray[i] = userInput % 10;
        userInput /= 10;
    }

    Console.WriteLine("Array of digits:");
    foreach (int digit in digitArray)
    {
        Console.Write(digit + " ");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a natural number between 1 and 100,000.");
}