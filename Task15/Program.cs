// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//    6 -> да
//    7 -> да
//    1 -> нет


Console.Clear();
Console.WriteLine("Введите цифру дня недели: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 6)
{
    Console.WriteLine("Нет, это рабочий день");
}
else if (number < 8)
{
    Console.WriteLine("Да, это выходной");
}
