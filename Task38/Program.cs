double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        arr [i] = Math.Round((arr[i]), 2, MidpointRounding.ToZero);
    }
    return arr;
}
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        arr [i] = Math.Round((arr[i]), 2, MidpointRounding.ToZero);
    }
    Console.Write("]");
}

double[] array = CreateArrayRndDouble(4, 0, 1);
PrintArray(array);


double maxFillarray = array[0];
double minFillarray = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxFillarray)
    {
        maxFillarray = array[i];
    }
    if (array[i] < minFillarray)
    {
        minFillarray = array[i];
    }
}

Console.WriteLine($" Разница между максимальным и минимальным элементом = {maxFillarray - minFillarray}");
