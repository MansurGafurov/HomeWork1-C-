﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Обозначте колличество чисел");
int [] array = new int [Convert.ToInt32(Console.ReadLine())];
int count = 0;
for(int i = 0; i<array.Length; i++) {
    Console.WriteLine("Введите число!");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if(array[i] > 0) count ++;
    }
Console.WriteLine($"Колличесиво чисел больше 0 =  {count}");
