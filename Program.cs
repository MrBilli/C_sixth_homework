// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void numberOfNumbersGreaterThanZero(int amount)
// {
//     int count = 0;
//     for(int i = 1; i <= amount; i++ )
//     {
//         Console.WriteLine($"Enter number #{i}:");
//         double temp = Convert.ToDouble(Console.ReadLine());
//         if(temp > 0)
//         count++;
//     }
//     Console.WriteLine($"Congratilations! You entered {count} numbers greater than zero.");
// }

// Console.WriteLine("Enter the number of numbers to be entered");

// int amountOfNumbers = Convert.ToInt32(Console.ReadLine());

// numberOfNumbersGreaterThanZero(amountOfNumbers);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double[] intersectionPoin(int k1, int k2, int b1, int b2)
// {
//     double[] intersection = new double[2];
//     double 0 = k1 * x + b1 - k2 * x + b2;
//     double y = k2 * x + b2
// }