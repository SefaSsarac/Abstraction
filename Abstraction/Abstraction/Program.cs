using Abstraction;

class Program
{
    static void Main(string[] args)
    {
        // Yazılım Geliştirici Nesnesi Oluşturma
        YazilimGelistirici yazilimci = new YazilimGelistirici("Ali", "Veli", "Yazılım");
        yazilimci.Gorev();

        // Proje Yöneticisi Nesnesi Oluşturma
        ProjeYoneticisi projeYoneticisi = new ProjeYoneticisi("Hasan", "Çıldırmış", "Proje Yönetimi");
        projeYoneticisi.Gorev();

        // Satış Temsilcisi Nesnesi Oluşturma
        SatisTemsilcisi satisTemsilcisi = new SatisTemsilcisi("Ayşe", "Yılmaz", "Satış");
        satisTemsilcisi.Gorev();
    }
}