﻿// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);
number=number/10;
number=number%10;
Console.WriteLine(number); 
