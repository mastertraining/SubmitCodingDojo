using System;

namespace Homework10.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new Lib.Homework10();
            svc.CreateMockProductIfFileNotExists();
            Console.Write(svc.LoadSavedCart());

            while (true)
            {
                var key = Console.ReadLine();
                if (key == "save")
                {
                    svc.SaveCurrentState();
                    Console.WriteLine(svc.SaveStateText);
                    Console.Write(svc.GetPrintString());
                }
                else
                {
                    if (!svc.AddProductByString(key))
                    {
                        Console.WriteLine(svc.NotFoundProductText);
                    }
                    else
                    {
                        Console.Write(svc.GetPrintString());
                    }
                }
            }
        }
    }
}
