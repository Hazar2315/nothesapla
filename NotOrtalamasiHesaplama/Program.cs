// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string secim;
do
{
    Console.WriteLine(" Ekrana çıkış için 'E', Hesaplama İçin 'H' girin ");
    secim = Console.ReadLine().ToUpper();
    if (secim == "H")
    {
        Console.WriteLine("Ders İsmini Girin: ");
        string dersAdi = Console.ReadLine();

        Console.WriteLine("Dersin kaç sınavı var");
        int notSayisi = int.Parse(Console.ReadLine());

        int toplamYuzde = 0;
        double totalPoints = 0;
    notGiris:
        for (int i = 0; i < notSayisi; i++)
        {
            
            Console.WriteLine((i+1)+". Sınavın Notu Giriniz: ");
            int not = int.Parse(Console.ReadLine());

            Console.WriteLine((i + 1) + ". Sınavın Yüzdesini Girin");
            int yuzde = int.Parse(Console.ReadLine());

            if (not < 0 || not > 100)
            {
                Console.WriteLine("Geçersiz Not, Not  0 ile 100 arasında olmalıdır");
                goto notGiris;
            }
            if (yuzde < 0 || yuzde > 100)
            {
                Console.WriteLine("Geçersiz yüzde, yüzde 0 ile 100 arasında olmalıdır");
                goto notGiris;
            }

            toplamYuzde += yuzde;
            totalPoints += (double)not * yuzde / 100;
        }

        if (toplamYuzde != 100)
        {
            Console.WriteLine("toplam yüzde 100'ün üstünde olamaz");
            goto notGiris;
        }

        double ortalama = totalPoints / toplamYuzde * 100;
        Console.WriteLine("Ders Adı: " + dersAdi);
        Console.WriteLine("Ortalama: " + ortalama);

        string harfNotu;
        if (ortalama >= 90)
            harfNotu = "AA";
        else if (ortalama >= 85)
            harfNotu = "BA";
        else if (ortalama >= 80)
            harfNotu = "BB";
        else if (ortalama >= 75)
            harfNotu = "CB";
        else
            harfNotu = "F";
        Console.WriteLine("Harf Notu: " + harfNotu);

        if (ortalama >= 60)
        {
            Console.WriteLine("Sonuç : " + harfNotu + " ile Geçti");
        }
    }
    else if (secim != "E")
    {
        Console.WriteLine("Invalid choice, enter 'E' for exit or 'H' for grade calculation");
    }
} while (secim != "E");