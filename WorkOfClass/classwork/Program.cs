using classwork.Class;
using System;

namespace classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please write how many notebook do you need  ");
            int count = int.Parse(Console.ReadLine());

            int[] arr = new int[] { 1, 2, 3 };
            NoteBook[] notebooks = new NoteBook[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write("please enter the brand name: ");
                string brandName = Console.ReadLine();

                Console.Write("please enter the model name: ");
                string model1 = Console.ReadLine();

                Console.Write("please enter the Ram: ");
                int ram = int.Parse(Console.ReadLine());


                Console.Write("please enter the Storage: ");
                int storage = int.Parse(Console.ReadLine());


                Console.Write("please enter the Price: ");
                double price = double.Parse(Console.ReadLine());


                Console.Write("please enter the Count: ");
                int coun = int.Parse(Console.ReadLine());


                notebooks[i] = new NoteBook(brandName, price, count);
                {
                    model1 = model1;
                    storage = storage;
                    ram = ram;


                }

                //notebooks[i].Ram = model1;
                //notebooks[i].Storage = storage;
                //notebooks[i].Model = price;

            }
            Console.WriteLine("List of notebooks");
            foreach (var item in notebooks)
            {
                item.GetInfo();
            }


        }
    }
}
