// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int result1 = num%7;
int result2= num%23;

if (result1==0 &&result2==0) Console.WriteLine("Число кратно на 3 и на 7");
else Console.WriteLine("Число не кратно на 3 и на 7");


// int MultiDigit(int number1, int number2)
// {
//     int result = number1%number2;
//     if(result==0) return 0;
//     else return result;
// }

// int multidigit = MultiGigit(num1,num2);

