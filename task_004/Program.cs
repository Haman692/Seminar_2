// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


Console.Clear();
Console.WriteLine("Введите число");
int ferstNumber = Convert.ToInt32 (Console.ReadLine());

if ((ferstNumber % 7 == 0) && (ferstNumber % 23 == 0)) Console.WriteLine($"{ferstNumber} картно 7 и 23");
else Console.WriteLine($"{ferstNumber} не картно 7 и 23");