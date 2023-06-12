// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// // которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// // Console.WriteLine("Укажите длину массива: ");
// // int sizeArray = int.Parse(Console.ReadLine());
// // int[] array = new int[sizeArray];
// // Random arrayRandomValue = new Random();
// // int evenNumber = 0;
// // for (int i = 0; i < sizeArray; i++)
// // {
// //     array[i] = arrayRandomValue.Next(100, 999);
// //     Console.Write($" | {array[i]}");

// //         if (array[i] % 2 == 0) 
// //             evenNumber++;
// // }


// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// // стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// // Console.WriteLine("Укажите длину массива: ");
// // int sizeArray = int.Parse(Console.ReadLine());
// // int[] array = new int[sizeArray];
// // Random arrayRandomValue = new Random();
// // int arraySummValue = 0;
// // for (int i = 0; i < sizeArray; i++)
// // {
// //     array[i] = arrayRandomValue.Next(-100, 100);
// //     Console.Write($" | {array[i]}");

// //     if (i % 2 != 0)
// //         arraySummValue += array[i];
// // }
// // Console.WriteLine($" \n Сумма элементов массива, стоящих на нечётных позициях = {arraySummValue}");


// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

// Console.WriteLine("Укажите длину массива: ");
// int sizeArray = int.Parse(Console.ReadLine());
// int[] array = new int[sizeArray];
// Random arrayRandomValue = new Random();
// int temp = 0;
// int differenceArrayValue = 0;
// Console.WriteLine(" Изначально несортированный массив:");
// for (int i = 0; i < sizeArray; i++)
// {
//     array[i] = arrayRandomValue.Next(-100, 100);
//     Console.Write($" | {array[i]}");
// }
// Console.WriteLine("\n \n Отсортированный массив массив:");
// for (int i = 0; i < array.Length; i++)
// {
//     for (int j = i + 1; j < array.Length; j++)
//     {
//         if (array[i] > array[j])
//         {
//             temp = array[i];
//             array[i] = array[j];
//             array[j] = temp;
//         }
//     }
//     Console.Write($" | {array[i]}");
// }
// differenceArrayValue = array[array.Length - 1] - array[0];
// Console.WriteLine($"\n \n Разница между максимальным и минимальным элементом массива: ");
// Console.WriteLine($" ({array[array.Length - 1]}) - ({array[0]}) = {differenceArrayValue}"); 