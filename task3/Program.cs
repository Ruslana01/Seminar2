// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine()!);
if (day==6 || day==7) 
{
      Console.WriteLine("Выходной день");
}
else
if (day<1 || day>7)
Console.WriteLine(" Такого дня не существует");
else 
Console.WriteLine("Этот рабочий день");