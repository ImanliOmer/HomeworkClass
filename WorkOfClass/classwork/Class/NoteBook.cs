using System;

namespace classwork.Class
{
    public class NoteBook: Product
    {
        string BrandName = "Asus Rog";
        string Model = "Gaming";
        int Ram = 16;
        int Storage = 500;



        public NoteBook(string brandname, double price, int count) : base(price, count)
        {
            BrandName = brandname;

        }

        public void GetInfo()
        {
            Console.WriteLine($"Bradn Name: {BrandName} Model: {Model} Ram: {Ram} Storage: {Storage} Price: {Price} Count: {Count}");
        }


    }   
}
