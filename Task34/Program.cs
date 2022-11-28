﻿int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
int[] array = CreateArrayRndInt(50, 1, 1000);
PrintArray(array);
int SumEvenElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0) sum += 1;
    return sum;
}
int sumEvenElem = SumEvenElem(array);
Console.WriteLine($" Количество четных чисел = {sumEvenElem}");
