using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("çalışan uygulamasına hoşgeldiniz...");
            Console.WriteLine("1- yazılımcı işleri");
            Console.WriteLine("2-yönetici işlemleri");
            Console.WriteLine("çıkış için q ya basınız");
            string secilenİslem = Console.ReadLine();

            while (true)
            {
                

                if (secilenİslem == "q")
                {
                    Console.WriteLine("programdan çıkılıyor.");
                    break;
                }
                else if (secilenİslem == "1")
                {
                    yazilimci yazilimci1=new yazilimci(1,"Ayşe","Söğüt","c++,c#");
                    Console.WriteLine("yazılımcı işlemi seçiniz:");
                    Console.WriteLine("1-format at");
                    Console.WriteLine("2-yazılımcı bilgilerini göster");
                    Console.WriteLine("3- çıkış için q ya basınız");

                    string yazilimciislem=Console.ReadLine();
                    while (true)
                    {
                        if(yazilimciislem== "q")
                        {
                            Console.WriteLine("yazılımcı işlemlerinden çıkış yapılıyor");
                            break;
                        }
                        else if(yazilimciislem=="1")
                        {
                            Console.Write("işletim sistemi giriniz:");
                            string isletimsistemi = Console.ReadLine();
                            yazilimci1.formatAt(isletimsistemi);
                        }
                        else if(yazilimciislem=="2")
                        {
                            yazilimci1.bilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz...");
                        }
                    }
                }
                else if (secilenİslem == "2")
                {
                    yonetici yonetici1 = new yonetici(1, "Pınar", "Altınkaya", 21);
                    Console.WriteLine("yönetici işlemi seçiniz:");
                    Console.WriteLine("1-zam yap");
                    Console.WriteLine("2-yönetici bilgilerini göster");
                    Console.WriteLine("3- çıkış için q ya basınız");
                    string yoneticiislem=Console.ReadLine();

                    while (true)
                    {
                        if(yoneticiislem=="q")
                        {
                            Console.WriteLine("Yönetici işlemlerinden çıkış yapılıyor...");
                            break;
                        }
                        else if(yoneticiislem=="1")
                        {
                            Console.Write("zam miktarını giriniz:");
                            int zamMiktari=Convert.ToInt32(Console.ReadLine());
                            yonetici1.zamYap(zamMiktari);
                        }
                        else if(yoneticiislem=="2")
                        {
                            yonetici1.bilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("lütfen geçerli bir işlem giriniz...");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("lütfen çalışan uygulaması için geçerli bir işlem seçiniz...");
                }

            }

        }
    }
}
