using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Name = "Oğuzhan";
            musteri.LastName = "Dilek";
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri);


            Console.ReadLine();
        }
    }
}
