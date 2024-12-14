using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public  class yonetici:calisan
    {
        private int sorumluKisisayisi;
        public yonetici(int id,string isim,string soyisim,int sorumluKisisayisi):base(id,isim,soyisim)
        {
            this.sorumluKisisayisi = sorumluKisisayisi;
        }

        public void zamYap(int zamMiktari)
        {
            Console.WriteLine(getIsim() + " " +zamMiktari+" "+"tl zam yapılıyor...");
        }
    }
}
