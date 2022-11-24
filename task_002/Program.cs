// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
Console.Clear();
int randomNumber = new Random().Next(100, 999);
Console.WriteLine("Случайное число " + randomNumber);

int secondDiget = randomNumber % 10;

int ferstDiget = randomNumber / 100;

Console.WriteLine(ferstDiget*10+secondDiget);


