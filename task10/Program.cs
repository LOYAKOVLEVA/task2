//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console. WriteLine("Введите трехзначное число");
int num = Convert. ToInt32(Console. ReadLine ( ));
if (num / 100 == 0 || num / 100 > 9 )
Console.WriteLine ("Неправильно введенное число");
else
{
num = num % 100;
}
num = num / 10;
Console.WriteLine (num) ;