using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // Abstract Base Class
    public abstract class Calisan
    {
        // Ortak Özellikler
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        // Constructor
        public Calisan(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }

        // Abstract Metot
        public abstract void Gorev();
    }

    // YazilimGelistirici sınıfı
    public class YazilimGelistirici : Calisan
    {
        public YazilimGelistirici(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        // Gorev metodunu override ediyoruz
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}, {Departman} departmanında Yazılım Geliştirici olarak çalışıyorum.");
        }
    }

    // ProjeYoneticisi sınıfı
    public class ProjeYoneticisi : Calisan
    {
        public ProjeYoneticisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        // Gorev metodunu override ediyoruz
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}, {Departman} departmanında Proje Yöneticisi olarak çalışıyorum.");
        }
    }

    // SatisTemsilcisi sınıfı
    public class SatisTemsilcisi : Calisan
    {
        public SatisTemsilcisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        // Gorev metodunu override ediyoruz
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}, {Departman} departmanında Satış Temsilcisi olarak çalışıyorum.");
        }
    }
}
