﻿/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Задание №2v2");

Console.WriteLine("Напишите программу,которая выводит третью цифру заданного числа ил сообщает что третьей цифры нет. ");

int number = Convert.ToInt32(Console.ReadLine());

string gg = Convert.ToString(number);
if (gg.Length > 1)
{
    Console.WriteLine("Третья цифра числа " + gg[2]);
}
else if (gg.Length > 2)
{
    Console.WriteLine("Третья цифра числа " + gg[2]);
}
else if (gg.Length > 4)
{
    Console.WriteLine("Ввод не соответствует задаче!\nВведите трехзначное число! ");
}
else
{
    Console.WriteLine("Ввод не соответствует задаче!\nВведите трехзначное число! ");
}
//Не понимаю почему не работает второй вариант! При выводе значения else if консоль сходит сума.