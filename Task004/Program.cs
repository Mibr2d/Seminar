// Задача 4: Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все чётные 
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число");
String stringValue = Console.ReadLine();
int number = Convert.ToInt32(stringValue);
int i=-number;
while(i>number+2)
i++;
if (number %2==0){
    System.Console.WriteLine($"Чётные числа ");
}
else System.Console.WriteLine($"Нечётные числа");
