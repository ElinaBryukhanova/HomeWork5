﻿// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[7];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] = new Random().Next(100, 1000));
    
    if (array[i] % 2 == 0)
    {
        sum = sum + 1;
    }
}
Console.WriteLine(sum);