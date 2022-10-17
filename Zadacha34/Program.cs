﻿    /* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    //Метод для создания массива размера size из случайных чисел из диапазона [start;end]
    */
Console.Write ("Введите число элементов массива: ");
int a = Convert.ToInt32 (Console.ReadLine());
int [] numbers = new int [a];
FillArray (numbers);
PrintArray (numbers);
int amount = 0;
for (int i = 0; i < a; i++)
    {
        if (numbers[i] % 2 == 0)
         {
             amount++;
         }
    }
    Console.WriteLine ("количество чётных чисел в массиве: "+amount);

void FillArray (int [] array)
  {
    for (int i =0; i < array.Length; i++)
    {
       numbers [i] = new Random().Next(0,1000);
    }

  }

  void PrintArray (int [] array)
  {
    for (int i =0; i < array.Length; i++)
    {
       Console.Write (numbers [i] + " ");
    }
    Console.WriteLine();
  }          

