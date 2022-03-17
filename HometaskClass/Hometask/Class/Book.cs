using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask.Class
{
    public class Book:Product
    {
        public string Genre;

        public Book(string genre,int number, string name, int price, double count):base(number, name, price)
        {
            Genre = genre;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Book Genere: {Genre} \n " +
                $"Book Name: {Name} \n" +
                $"Book price: {Price} \n" +
                $"Book No: {Number}");
        }

    }
}
