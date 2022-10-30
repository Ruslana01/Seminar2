// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трехзначное число");
string UserNumber =(Console.ReadLine());

if (UserNumber.Length<3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
Console.WriteLine("Третье число это-"+ UserNumber[2]);
