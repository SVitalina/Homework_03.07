//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа

int a = new Random().Next(100, 999);
int centre = 0; 
int centre1 = 0; 

centre = a%100;
centre1 = centre/10;


Console.WriteLine(a);
Console.WriteLine(centre1);
