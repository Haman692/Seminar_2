// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Clear();
Console.WriteLine("Введите число");
int ferstNumber = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Второе число");
int secondNumber = Convert.ToInt32 (Console.ReadLine());
int ostatok = ferstNumber % secondNumber;

if(ferstNumber % secondNumber == 0) Console.WriteLine($"{ferstNumber} кратно {secondNumber} ");
else Console.WriteLine($"{ferstNumber} не кратно {secondNumber}, остаток {ostatok}");