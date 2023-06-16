// Напишите программу которая принимает на вход цифру ,
//   обозначающую день недели , и проверяет , являеться ли этот день выходным.



System.Console.Write("Введите день недели: ");
int WeekDay = Convert.ToInt32(Console.ReadLine());
string[] message = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" , "Воскресенье"};
if (WeekDay > 0 && WeekDay < 8)
{
    System.Console.WriteLine(message[WeekDay - 1]);
    if (WeekDay > 5 && WeekDay < 8)
    {
        System.Console.WriteLine("Это выходной день!");
    }
}
else
{
    System.Console.WriteLine("Такого дня не существует!");
}

/*
using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите день недели (1-7): ");
        int dayOfWeek = int.Parse(Console.ReadLine());

        if (dayOfWeek == 6 || dayOfWeek == 7) {
            Console.WriteLine("Это выходной день!");
        } else {
            Console.WriteLine("Это рабочий день!");
        }

        Console.ReadLine();
    }
}*/