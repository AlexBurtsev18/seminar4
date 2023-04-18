﻿// Task 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int Sum(int n)
{
    int summa = 0;
    for(int count = 1; count<=n; count++)
    {
        summa = summa + count;
    }
    return summa;
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = Sum(num);
Console.WriteLine($"Введенное число {num}, Сумма {res}");

// Task 2. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int Factorial(int n)
// {
//     int comp = 1;
//     int count = 1;
//     while(count <=n)
//     {
//         comp = comp * count;
//         count ++;
//     }
//     return comp;
// }
// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine()); 
// int result = Factorial(num);
// Console.WriteLine($"Введенное число {num}, Произведение - {result}");



// // Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// using System.Numerics;

// //Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// //Выводим результат пользователю
// void PrintData(string msg1, BigInteger msg2)
// {
//     Console.WriteLine(msg1);
//     Console.WriteLine(msg2);
// }

// BigInteger CalcFact(int num)
// {
//     BigInteger res=1;
//     for(int i=1;i<=num;i++)
//     {
//         res=res*i;
//     }
//     return res;
// }

// int number = ReadData("Введите число:");

// BigInteger fact = CalcFact(number);

// PrintData("Факториал равен: ",fact);