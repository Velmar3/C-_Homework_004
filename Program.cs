/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// int SumDigits(int n)
// {
//     int sum = 0;

//     while(n > 0)
//     {
//         sum += n % 10;
//         n /= 10;
//     }

//     Console.Write("Сумма чисел: " + sum);

//     return sum;      
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());  
    
// SumDigits(number);

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

// int[] Array(int size)
// {
//     int[] array = new int [size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 99);
//     }

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//        Console.Write(array[i] + " ");

//     Console.WriteLine(); 
// }
    
// Console.Write("Массив из 8 элементов: ");
// int size = 8;

// int[] myArray = Array(size);
// ShowArray(myArray);
