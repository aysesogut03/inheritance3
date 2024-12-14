using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public class yazilimci:calisan
    {
        private string diller;
        public yazilimci(int id,string isim,string soyisim,string diller):base(id, isim, soyisim) 
        {
            this.diller = diller;
        }

        public void formatAt(string isletimsistemleri)
        {
            Console.WriteLine(getIsim() + "şuanda" + isletimsistemleri + "format atıyor.");
        }
        
    }
}
