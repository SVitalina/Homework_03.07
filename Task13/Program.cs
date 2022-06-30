// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет

int a = new Random().Next(1, 999);
int last = 0 ;

last = a%10;

if(a > 99)
{ 
    Console.WriteLine(a);
    Console.WriteLine(last);
}

else 
{
    Console.WriteLine(a);
    Console.WriteLine("Третьей цифры нет");
}