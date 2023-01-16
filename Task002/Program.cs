// Задача 2: Напишите программу, которая принимает на 
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число");
String stringValue = Console.ReadLine();
int number = Convert.ToInt32(stringValue);
System.Console.WriteLine("Введите второе  число");
String stringValue1 = Console.ReadLine();
int number1 = Convert.ToInt32(stringValue1);
System.Console.WriteLine("Введите третье число");
String stringValue2 = Console.ReadLine();
int number2 = Convert.ToInt32(stringValue2);
int max =0;
if (number>number1){
    max = number;
}
else max = number1;
if(number>number2){
    max = number;
}
else max = number2;
System.Console.WriteLine($"Максимальное число {max}, ");