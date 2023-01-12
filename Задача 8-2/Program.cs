using System;

string path = @"D:\Учеба бим\Test.txt";
Random random = new Random();
using(StreamWriter sw = new StreamWriter(path, false))
{
    for (int i=0; i<10; i++)
    {
        sw.WriteLine(random.Next(-10, 10));
    }
}

int Sum = 0;
using (StreamReader sr = new StreamReader(path))
{
    for (int i = 0; i < 10; i++)
    {
        Sum += (Convert.ToInt32(sr.ReadLine()));
    }
}
Console.WriteLine("Сумма 10 случайных чисел в текстовом файле равна:");
Console.WriteLine(Sum);