// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
int num = new Random().Next(10, 100);
//Console.WriteLine(num);
int pervoe_ch = num / 10;
int vtoroe_ch = num % 10;
if (pervoe_ch == vtoroe_ch) Console.WriteLine("Чифры равны");
if (pervoe_ch > vtoroe_ch) Console.WriteLine($"{num} ->  {pervoe_ch}");
else Console.WriteLine($"{num} ->  {vtoroe_ch}");


