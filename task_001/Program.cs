//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Clear();
int randomNumber = new Random().Next(10, 100);
Console.WriteLine("Случайное число " + randomNumber);

int ostatok = randomNumber % 10;
Console.WriteLine("Второе число " + ostatok);

int delitel = randomNumber/10;
Console.WriteLine("Первое число " + delitel);

if(delitel > ostatok) Console.WriteLine("Наибольшое " + delitel);
else Console.WriteLine("Наибольшое " + ostatok);