//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());

if (b == 6 || b == 7)
{
    Console.WriteLine("Ура, Выходной день!");
}
    if (b >= 1 && b<= 5)
{
    Console.WriteLine("Будний день:(");
}    

if (b > 7)
{
    Console.WriteLine("Это не день недели");
}