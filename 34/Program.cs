// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] array = GetRandomArray(4, 100, 1000);
int evenCount = GetEvenCount(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> {evenCount}");

///////////////////////////////////////////////////////////////////////
int[] GetRandomArray(int size, int minValue, int maxValue) 
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++) 
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

int GetEvenCount(int[] numbers) 
{
    int result = 0;
    for(int i = 0; i < numbers.Length; i++) 
    {
        if(numbers[i] % 2 == 0) result++;
    }
    return result;
}