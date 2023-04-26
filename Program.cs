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




