/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

double[] InitArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]};  ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double FindMaxNumber(double[] array)
{
    double max = array[array.Length-1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double FindMinNumber(double[] array)
{
    double min = array[array.Length-1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}


double[] arr = InitArray(8, 1, 10);
PrintArray(arr);
double max1 = FindMaxNumber(arr);
double min1 = FindMinNumber(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна -> {Math.Round(max1 - min1, 1)}");