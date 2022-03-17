using Hometask.Class;
using System;

namespace Hometask
{
    internal class Program
    {
        private static string genre;

        static void Main(string[] args)
        {
            Console.WriteLine("Please write how many books do you want: ");
            int count = int.Parse(Console.ReadLine());

            Book[] books = new Book[count]; 

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("kitab No: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("kitabin adini yazin: ");
                string name = Console.ReadLine();

                Console.WriteLine("kitabin qiymetini qeyd edin: ");
                double price = double.Parse(Console.ReadLine());


                books[i] = new Book( genre, number,name,count ,price)
                {
                    Count = count
                };
            }
            foreach (var item in books)
            {
                item.GetInfo();
            }

        }
    }
}
