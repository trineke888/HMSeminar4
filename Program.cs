// ﻿// Задача №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

// int ReadData(string msg) // Ввод данных
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// long MyPow(int numA, int numB) //Рассчет возведения числа А в степень В
// {
//     long res = 1;
//     while (numB > 0)
//     {
//         res = res * numA;
//         numB = numB - 1;
//     } 

//     return res;

// }

// void PrintResult(string msg) //Печатаем результат
// {
//     Console.WriteLine(msg);
// }

// int numA = ReadData("Введите число А: ");
// int numB = ReadData("Введите число В: ");
// long res = MyPow(numA, numB);
// PrintResult("Степень числа А = "+res);

// // Введите число А:
// // 3
// // Введите число В:
// // 5
// // Степень числа А = 243
// // PS C:\Users\eka333\Desktop\Analitik\C#\HWSeminar4> dotnet run
// // Введите число А: 
// // 2
// // Введите число В: 
// // 4
// // Степень числа А = 16


// ﻿// Задача №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// int ReadData(string msg) // Ввод данных
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// int sumDigit(int num) //Считаем сумму цифр в числе
// {
//     int res =0;
//     while (num > 0)
//     {
//         res = res + num%10;
//         num = num / 10;
//     }

//     return res;
// }

// void PrintResult(string msg) //Печатаем результат
// {
//     Console.WriteLine(msg);
// }

// int num = ReadData("Введите число: ");
// int res = sumDigit(num);
// PrintResult("Сумма чисел = " +res);


// // Введите число:
// // 452
// // Сумма чисел = 11
// // PS C:\Users\eka333\Desktop\Analitik\C#\HWSeminar4> dotnet run
// // Введите число:
// // 82
// // Сумма чисел = 10
// // PS C:\Users\eka333\Desktop\Analitik\C#\HWSeminar4> dotnet run
// // Введите число: 
// // 9012
// // Сумма чисел = 12


// ﻿// Задача №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int ReadData(string msg) //Ввод данных
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }


// void PrintArray(int[] arr)  // Печатаем результат
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
        
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }
// int[] GenArr(int len) //Создаем массив со случайными числами. Указываем диапазон чисел массива 
// {
//     int[] arr = new int[len];
//     Random rnd = new Random();
//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = rnd.Next(0, 10);
//     }
//     return arr;
// }

// int num = ReadData("Введите число: ");
// int[] res = GenArr(num);
// PrintArray(res);

// // Введите число:
// // 8
// // [2, 6, 4, 0, 4, 1, 4, 7]
// // PS C:\Users\eka333\Desktop\Analitik\C#\HWSeminar4> dotnet run
// // Введите число: 
// // 6
// // [1, 4, 4, 4, 9, 7]
