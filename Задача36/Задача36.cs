// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[4];
int sum = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    Console.WriteLine(array[i] = new Random().Next());
        sum = sum + array[i];
}
Console.WriteLine(sum);