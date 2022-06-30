//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.

int day = new Random() .Next(1, 7) ;
Console.WriteLine(day);

if (day < 6)
{
    Console.WriteLine("Робочий день");
}
if (day >= 6)
{
    Console.WriteLine("Выходной день");
}