// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] array = GetRandomArray(5, 20);
double numberDiff = GetNumberDiff(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> {numberDiff}");

//////////////////////////////////////////////////////////////////////////////////////

double[] GetRandomArray(int size, int factor) 
{
    double[] result = new double[size];
    for(int i = 0; i < size; i++) 
    {
        result[i] = new Random().NextDouble() * factor;
    }
    return result;
}

double GetNumberDiff(double[] numbers) 
{
    double max = 0;
    for(int i = 0; i < numbers.Length; i++) 
    {
        if(numbers[i] > max) max = numbers[i];
    }
    double min = max;
    for(int i = 0; i < numbers.Length; i++) 
    {
        if(numbers[i] < min) min = numbers[i];
    }
    double result = max - min;
    return result;
}