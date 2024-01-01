using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLassMetotDemo
{
    public class MusteriManager : IMusteriService<Musteri>
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name+" :Müşteri Kaydı Yapıldı");
        }

        public void Delete()
        {
            Console.WriteLine("Silme Yapıldı");
        }

        public void Update()
        {
            Console.WriteLine("Güncelleme Yapıldı");
        }
    }
}
