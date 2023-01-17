// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] array = GetRandomArray(6, -20, 20);
int oddIndexSum = GetOddIndexSum(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> {oddIndexSum}");

/////////////////////////////////////////////////////////////
int[] GetRandomArray(int size, int minValue, int maxValue) 
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++) 
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

int GetOddIndexSum(int[] numbers) 
{
    int sum = 0;
    for(int i = 1; i < numbers.Length; i += 2) sum += numbers[i];
    return sum;
}