// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] array = new int[123];
int sum = 0; // количество элементов массива
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] = new Random().Next());
    
    if (array[i] >= 10 && array[i] <= 99)
    {
        sum = sum + 1;
    }
}
Console.WriteLine(sum);