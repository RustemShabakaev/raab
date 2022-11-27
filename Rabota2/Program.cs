// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным
// элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
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
        if (i < array.Length - 1) Console.Write($"{array[i]} , ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double Raznica(double[] array)
{
    double min = array[0];
    double max = array[0];
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }
    result = max - min;
    return result;
}
double[] arr = CreateArrayRndDouble(6, 1, 5);
double itog = Raznica(arr);
PrintArray(arr);
itog = Math.Round(itog, 1);
Console.Write($"-> {itog}");
