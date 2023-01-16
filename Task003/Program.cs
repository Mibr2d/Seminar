// Задача 3: Напишите программу, которая на вход 
// принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
System.Console.WriteLine("Введите число");
String stringValue = Console.ReadLine();
int number = Convert.ToInt32(stringValue);
if (number%2==1)
{
    System.Console.WriteLine($"{number} не является чётным числом");
}
else System.Console.WriteLine($"{number} является чётным числом");