// 11) Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int x = new Random().Next(100, 1000);
// int x1 = x / 100;
// int x2 = x % 10;
// Console.WriteLine($"{x}");
// Console.WriteLine($"{x1}{x2}");


// 12) Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите первое значение :");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе значение :");
// int x2 = Convert.ToInt32(Console.ReadLine());

// if (x1 % x2 == 0)
//  {
//    Console.WriteLine("Кратно");
//  }
//   else
//   {
//    Console.WriteLine($"Не кратно :{x1 % x2}");
//   }

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да


// Console.WriteLine("Введите значение :");
// int x = Convert.ToInt32(Console.ReadLine());
// if ((x % 7 == 0) && (x % 23 == 0))
// {
//  Console.WriteLine("Кратно");   
// }
// else
// {
//  Console.WriteLine($"Не кратно :");  
// }


// 16) Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

//  Console.WriteLine("Введите первое значение :");
//  int x = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите второе значение :");
//  int y = Convert.ToInt32(Console.ReadLine());

//  if ((x * x == y) || (y * y == x))
//  {
//     Console.WriteLine("Да");
//  }
//  else
//   {
//     Console.WriteLine("Нет");
//   }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//int x = new Random().Next(100, 999);
// Console.WriteLine("Введите значение x:");
// int x = Convert.ToInt32(Console.ReadLine());
// int x2 = (x % 100) / 10;
// Console.WriteLine($"{x}");
// Console.WriteLine($"{x2}");
 


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
    string N = Console.ReadLine();
    int len_N = N.Length;
    if ( len_N < 3 ) 
      {
        Console.WriteLine("Третьго числа нет");
      }
    else
      {
        int x = Convert.ToInt32(N);
        for (int i = 3; i < len_N; i++)
          {            
            x = x / 10;  
          }  
        if (x % 10 == 0)
          {
            Console.WriteLine(0);
          }
        else
          {
            Console.WriteLine(x - x / 10 * 10);
          }
      }
      

      
   


// if (x1 > 0)
//  {
//    Console.WriteLine($"{x1}");
//  }
//    Console.WriteLine("Третьей цифры нет");
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string[] mas = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресение"};

//     if(num > 5 && num < 8)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine($"Нет");
//     }




// 10

//int x = new Random().Next(100, 999);
// Console.WriteLine("Введите значение x:");
// int x = Convert.ToInt32(Console.ReadLine());
// int x2 = (x % 100) / 10;
// Console.WriteLine($"{x}");
// Console.WriteLine($"{x2}");