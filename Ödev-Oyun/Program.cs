namespace Ödev_Oyun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kullanicikolay, kullaniciorta, kullanicizor, kolay, orta, zor;
            int skor = 100;
            Random rnd_kolay = new Random();
            kolay = rnd_kolay.Next(1, 5);
            Console.WriteLine("Sayı Tahmin Oyununa Hoşgeldiniz. Bölüm: Kolay");
            do
            {
                Console.WriteLine("1 ile 5 arasında tahmin yapınız.");
                kullanicikolay = Convert.ToInt32(Console.ReadLine());
                if (kullanicikolay == kolay)
                {
                    Console.WriteLine("Tebrikler doğru cevap. Bir üst seviyeye geçtiniz : Orta");
                    Random rnd_orta = new Random();
                    orta = rnd_orta.Next(1, 10);
                    do
                    {
                        Console.WriteLine("1 ile 10 arası bir değer giriniz : ");
                        kullaniciorta = Convert.ToInt32(Console.ReadLine());
                        if (kullaniciorta == orta)
                        {
                            Console.WriteLine("Tebrikler doğru cevap. Bir üst seviyeye geçtiniz : Zor");
                            Random rnd_zor = new Random();
                            zor = rnd_zor.Next(1, 15);

                            do
                            {
                                Console.WriteLine("1 ile 15 arası bir değer giriniz : ");
                                kullanicizor = Convert.ToInt32(Console.ReadLine());
                                if(kullanicizor == zor)
                                {
                                    Console.WriteLine("Tebrikler kazandınız, puanınız : " +skor);
                                    skor = 0;
                                }

                                else
                                {
                                    skor -= 15;
                                    Console.WriteLine("Yanlış cevap , puanınız : " +skor);
                                }
                            } while (skor > 0);
                        }

                        else
                        {
                            skor -= 10;
                            Console.WriteLine("Yanlış cevap , puanınız : " + skor);
                        }

                    } while (skor > 0);

                }

                else
                {
                    skor -= 5;
                    Console.WriteLine("Yanlış cevap, puanınız : " + skor);
                }

            } while (skor > 0);

        }
    }
}
