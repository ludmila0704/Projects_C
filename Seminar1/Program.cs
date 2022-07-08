// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.Clear();
Console.Write("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
//int a =4;
int res = num*num;

//string a = Console.ReadLine();
//Console.WriteLine("");
Console.WriteLine($"квадрат числа {num}={res}");
