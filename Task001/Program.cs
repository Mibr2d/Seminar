﻿// Задача 1: Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а 
// какое меньшее.
// a = 5; b = 7 -> max = 7, 
// min = 5
// a = -9 b = -3 -> max = -3, 
// min = -9

System.Console.WriteLine("Введите первое число");
String stringValue = Console.ReadLine();
int number = Convert.ToInt32(stringValue);
System.Console.WriteLine("Введите второе число число");
String stringValue1 = Console.ReadLine();
int number1 = Convert.ToInt32(stringValue1);
int max = 0;
if (number>number1){
    max = number;
}
else max = number1;
System.Console.WriteLine($"Максимальное число {max}, ");