//я считаю это решение не правальным 
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Задание №10 v 2");
Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
int number = new Random().Next(100, 999);
Console.WriteLine($"===> {number}");
int Togo = number % 100;
Console.WriteLine($"===> {Togo}");
int Togo2 = Togo / 10;
Console.WriteLine($"Вторая цифра числа ==> {Togo2}");
