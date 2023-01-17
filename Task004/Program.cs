// Задача 4: Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все чётные 
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// System.Console.WriteLine("Введите число (от 1...N)");
// String stringValue = Console.ReadLine();
// int number = Convert.ToInt32(stringValue);
// int i = 1;
// while (number <= 0)
// {
//     Console.WriteLine("Не верно");
//     break;
// }
// while (i <= number)
// {
//     if (i % 2 == 0)
//     {
//         Console.Write($"{i} ");

//     }
//     i++;
// }

System.Console.WriteLine("Введите число (от 1...N)");
String stringValue = Console.ReadLine();
int number = Convert.ToInt32(stringValue);
int i = 2;
while (i <= number)
{
    Console.Write($"{i} ");


    i+=2;
}