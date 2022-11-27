/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

int[] InitArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int GetSumNotEvenPosition(int [] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i++)
    {
        count = count + array[i];
        i++;
    }
    return count;
}

int[] arr = InitArray(8, -10, 10);
PrintArray(arr);

int res = GetSumNotEvenPosition(arr);
Console.WriteLine($"Сумму элементов, стоящих на нечетных позициях -> {res}");