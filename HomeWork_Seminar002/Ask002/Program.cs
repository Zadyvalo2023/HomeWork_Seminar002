
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num < 100) {
      Console.WriteLine("Третьей цифры нет");
    }
    else {
      int thirdDigit = (num / 100) % 10;
      Console.WriteLine("Третья цифра: " + thirdDigit);
    }
  }
}




/*
using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();
        
        if (input.Length >= 3) {
            Console.WriteLine("Третья цифра: " + input[2]);
        } else {
            Console.WriteLine("Третьей цифры нет.");
        }
    }
}*/
/*
using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());

        int thirdDigit = GetThirdDigit(num);

        if (thirdDigit != -1) {
            Console.WriteLine($"Третья цифра числа {num} равна {thirdDigit}");
        } else {
            Console.WriteLine($"У числа {num} нет третьей цифры");
        }
    }

    static int GetThirdDigit(int num) {
        if (num >= 100 && num <= 999) {
            return (num / 10) % 10;
        } else {
            return -1;
        }
    }
}
*/