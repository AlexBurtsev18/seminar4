// Task 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int Sum(int n)
// {
//     int summa = 0;
//     for(int count = 1; count<=n; count++)
//     {
//         summa = summa + count;
//     }
//     return summa;
// }
// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = Sum(num);
// Console.WriteLine($"Введенное число {num}, Сумма {res}");

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

// HOMEWORK. 
// Task 25++. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// double Compare(double A, double B)
// {
//     double res = Math.Pow(A, B);
//     return res;
// }
// Console.WriteLine("Imput number A: ");
// double A = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Imput number B: ");
// double B = Convert.ToDouble(Console.ReadLine());
// double result = Compare(A, B);
// Console.WriteLine($"Число {A} в степени {B} составляет {result}");

// Task 27+. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumDigits(int num)
// {
//     int hundreds = num / 100;
//     int decades = (num / 10) % 10;
//     int unites = num % 10;
//     int sep = hundreds + decades + unites;
//     return sep;
// }
// Console.Write("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = SumDigits(num);
// Console.WriteLine($"If separate number {num} and sum digits, we`re got {result}");


// Task 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);