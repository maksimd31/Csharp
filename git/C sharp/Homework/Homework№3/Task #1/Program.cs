﻿/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Задача №1\nНапишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("Введите пятизначное число: ");

int numb = Convert.ToInt32(Console.ReadLine());

string ggg = Convert.ToString(numb);

if (ggg[0] == ggg[4])
{
    if (ggg[1] == ggg[3])
    Console.WriteLine($"Число {ggg} является палиндромом");
}
else
{
    Console.WriteLine($"Число {ggg} Не является палиндромом");
}
//Я не понял как решить по дргому? как решить матиматически, плохо знаю матиматику но палиндромом может не только цыфры но и буквы..
