// -------------------------Домашнее задание------------------------


// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!); 
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!); 
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// SortArray(array);
// PrintArray(array);

// // --------------------методы-------------------------

// int[,] GetArray(int n, int m, int min, int max){
//     int[,] result = new int[n, m];
//     for(int i = 0; i < n; i++){
//         for(int j = 0; j < m; j++){
//             result[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//      for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int t = j + 1; t < array.GetLength(1); t++)
//             {
//                 if(array[i, t] > array[i, j])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, t];
//                     array[i, t] = temp;
//                 }
//             }
//         }
//     }
// }

// ---

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите число количества строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число количества столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Console.WriteLine($"Строка с наименьшей суммой -> {GetRowNumber(array)}");


// // ------------------------методы-------------------------

// int[,] GetArray(int n, int m, int min, int max){
//     int[,] array = new int[n, m];
//     for(int i = 0; i < n; i++){
//         for(int j = 0; j < m; j++){
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array){
//      for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int GetRowNumber(int[,] array)
// {
//     int row = 0;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minsum = minsum + array[0, i];
//     }
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             sum = sum + array[i, j];
//         }
//         if(minsum > sum)
//         {
//             minsum = sum;
//             row = i;
//         }
//     }
//     return row;
// }



// ---

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк 1 массива: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 массива: ");
int columnsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк 2 массива: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 массива: ");
int columnsB = int.Parse(Console.ReadLine()!);
if(rowsA != columnsA)
{
    Console.WriteLine($"Такие матрицы перемножать нельзя");
    return;
}

int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);
PrintArray(A);
Console.WriteLine();
PrintArray(B);
Console.WriteLine();
PrintArray(GetMultiplicationMatrix(A, B));



// ------------------------методы-------------------------

int[,] GetArray(int n, int m, int min, int max){
    int[,] array = new int[n, m];
    for(int i = 0; i < n; i++){
        for(int j = 0; j < m; j++){
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array){
     for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
       for (int j = 0; j < arrayB.GetLength(1); j++)
       {
            for (int k = 0; k < arrayB.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }            
       } 
    }
    return arrayC;
}


// ---
// -------------------**Задачи повышенной сложности**---------------------
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




