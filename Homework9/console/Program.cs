using System;

public class Program
{
    static void Main(string[] args)
    { //**** เหลือสร้าง display ใช่ strinbuilder *****/
        Homework09 hm9 = new Homework09();
        foreach (var value in hm9.GetAllProducts())
        {
            Console.WriteLine(value.Name);
        }
    }
}
