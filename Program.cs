using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("isim yaz");
            string input = Console.ReadLine();

            bool asdfg = true;

            while (asdfg)
            {
               

                Console.WriteLine("merhaba " + input + "menüden bir şey sec");
                Console.WriteLine("Toplama (t)çıkarma (c) çarpma (x) bölme (b) yüzde işlemi (y) kar hesaplama (k) dikdörtgen hesaplama (d)");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "t":
                        Console.WriteLine("1. sayı");
                        int top1;
                        if (!int.TryParse(Console.ReadLine(), out top1))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }

                        Console.WriteLine("toplanacak 2. sayi");
                        int top2;
                        if (!int.TryParse(Console.ReadLine(), out top2))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }

                        int toplam = top1 + top2;
                        Console.WriteLine("cevap " + toplam);

                        if (toplam % 15 == 0)
                        {
                            Console.Write("NE MUTLU ");
                        }

                        if (toplam % 3 == 0)
                        {
                            Console.Write("NE ");
                        }

                        if (toplam % 7 == 0)
                        {
                            Console.Write("TÜRKİYE");
                        }

                        if (toplam % 15 == 0)
                        {
                            Console.Write("NE MUTLU");
                        }

                        if (toplam % 21 == 0)
                        {
                            Console.Write("NE TÜRKİYE");
                        }

                        if (toplam % 35 == 0)
                        {
                            Console.Write("MUTLU TÜRKİYE");
                        }

                        if (toplam % 105 == 0)
                        {
                            Console.Write("MUTLU TÜRKİYE");
                        }

                        break;



                    case "c":

                        Console.WriteLine("büyük sayıyı yaz");
                        int sayi1;
                        if (!int.TryParse(Console.ReadLine(), out sayi1))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }

                        Console.WriteLine("küçük sayıyı yaz");
                        int sayi2;
                        if (!int.TryParse(Console.ReadLine(), out sayi2))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }

                        int fark = sayi1 - sayi2;
                        Console.WriteLine("cevap " + fark);

                        if (fark % 15 == 0)
                        {
                            Console.Write("NE MUTLU ");
                        }

                        if (fark % 3 == 0)
                        {
                            Console.Write("NE ");
                        }

                        if (fark % 7 == 0)
                        {
                            Console.Write("TÜRKİYE");
                        }

                        if (fark % 15 == 0)
                        {
                            Console.Write("NE MUTLU");
                        }

                        if (fark % 21 == 0)
                        {
                            Console.Write("NE TÜRKİYE");
                        }

                        if (fark % 35 == 0)
                        {
                            Console.Write("MUTLU TÜRKİYE");
                        }

                        if (fark % 105 == 0)
                        {
                            Console.Write("MUTLU TÜRKİYE");
                        }

                        break;

                    case "x":
                        Console.WriteLine("ilk sayıyı yaz");
                        int carp1;
                        if (!int.TryParse(Console.ReadLine(), out carp1))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }

                        Console.WriteLine("ikinci sayıyı yaz");
                        int carp2;
                        if (!int.TryParse(Console.ReadLine(), out carp2))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }

                        int carpcevap = carp1 * carp2;
                        Console.WriteLine("Sonuç: " + carpcevap);

                        if (carpcevap % 15 == 0)
                        {
                            Console.Write("NE MUTLU ");
                        }

                        if (carpcevap % 3 == 0)
                        {
                            Console.Write("NE ");
                        }

                        if (carpcevap % 7 == 0)
                        {
                            Console.Write("TÜRKİYE");
                        }

                        if (carpcevap % 15 == 0)
                        {
                            Console.Write("NE MUTLU");
                        }

                        if (carpcevap % 21 == 0)
                        {
                            Console.Write("NE TÜRKİYE");
                        }

                        if (carpcevap % 35 == 0)
                        {
                            Console.Write("MUTLU TÜRKİYE");
                        }

                        if (carpcevap % 105 == 0)
                        {
                            Console.Write("MUTLU TÜRKİYE");
                        }

                        break;

                    case "b":
                        Console.WriteLine("İlk sayıyı yaz");
                        int bol1;
                        if (!int.TryParse(Console.ReadLine(), out bol1))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }

                        Console.WriteLine("ikinci sayıyı yaz");
                        int bol2;
                        if (!int.TryParse(Console.ReadLine(), out bol2))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }
                        if (bol2 == 0)
                        {
                            Console.WriteLine("bir şeyi 0a bölemezsin");
                        }
                        
                        else
                        {
                            double bolum = (double)bol1 / bol2;
                            Console.WriteLine("cevap " + bolum);

                            if (bolum % 15 == 0)
                            {
                                Console.Write("NE MUTLU ");
                            }

                            if (bolum % 3 == 0)
                            {
                                Console.Write("NE ");
                            }

                            if (bolum % 7 == 0)
                            {
                                Console.Write("TÜRKİYE");
                            }

                            if (bolum % 15 == 0)
                            {
                                Console.Write("NE MUTLU");
                            }

                            if (bolum % 21 == 0)
                            {
                                Console.Write("NE TÜRKİYE");
                            }

                            if (bolum % 35 == 0)
                            {
                                Console.Write("MUTLU TÜRKİYE");
                            }

                            if (bolum % 105 == 0)
                            {
                                Console.Write("MUTLU TÜRKİYE");
                            }
                        }

                        break;

                    case "y":
                        Console.WriteLine("sayıyı yaz");
                        int yuzde1;
                        if (!int.TryParse(Console.ReadLine(), out yuzde1))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }

                        Console.WriteLine("sayinin % kaçı alınacak");
                        int yuzde2;
                        if (!int.TryParse(Console.ReadLine(), out yuzde2))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }

                        double cevapyuzde = (double)yuzde1 * yuzde2 / 100;
                        Console.WriteLine("cevap " + cevapyuzde);

                        if (cevapyuzde % 15 == 0)
                        {
                            Console.Write("NE MUTLU ");
                        }

                        if (cevapyuzde % 3 == 0)
                        {
                            Console.Write("NE ");
                        }

                        if (cevapyuzde % 7 == 0)
                        {
                            Console.Write("TÜRKİYE");
                        }

                        if (cevapyuzde % 15 == 0)
                        {
                            Console.Write("NE MUTLU");
                        }

                        if (cevapyuzde % 21 == 0)
                        {
                            Console.Write("NE TÜRKİYE");
                        }

                        if (cevapyuzde % 35 == 0)
                        {
                            Console.Write("MUTLU TÜRKİYE");
                        }

                        if (cevapyuzde % 105 == 0)
                        {
                            Console.Write("MUTLU TÜRKİYE");
                        }

                        break;


                    case "k":
                        Console.WriteLine("ürünü aldığın fiyatı yaz");
                        int alis;
                        if (!int.TryParse(Console.ReadLine(), out alis))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }

                        Console.WriteLine("ürünü sattığın fiyatı yaz");
                        int satis;
                        if (!int.TryParse(Console.ReadLine(), out satis))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }

                        int kar = alis - satis;
                        Console.WriteLine("kâr " + kar);

                        if (kar % 15 == 0)
                        {
                            Console.Write("NE MUTLU ");
                        }

                        if (kar % 3 == 0)
                        {
                            Console.Write("NE ");
                        }

                        if (kar % 7 == 0)
                        {
                            Console.Write("TÜRKİYE");
                        }

                        if (kar % 15 == 0)
                        {
                            Console.Write("NE MUTLU");
                        }

                        if (kar % 21 == 0)
                        {
                            Console.Write("NE TÜRKİYE");
                        }

                        if (kar % 35 == 0)
                        {
                            Console.Write("MUTLU TÜRKİYE");
                        }

                        if (kar % 105 == 0)
                        {
                            Console.Write("MUTLU TÜRKİYE");
                        }

                        break;

                    case "d":
                        Console.WriteLine("uzun kenarı yaz");
                        int uzunk;
                        if (!int.TryParse(Console.ReadLine(), out uzunk))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }

                        Console.WriteLine("dikdörtgenin kısa kenarını yaz");
                        int kisak;
                        if (!int.TryParse(Console.ReadLine(), out kisak))
                        {
                            Console.WriteLine("sayı girmen lazım");
                            break;
                        }

                        int alan = uzunk * kisak;
                        int cevre = (uzunk + kisak) *2;

                        Console.WriteLine("alan " + alan);
                        Console.WriteLine("cevre " + cevre);

                        if (alan % 15 == 0 || cevre % 15 == 0)
                        {
                            Console.Write("NE MUTLU ");
                        }

                        if (alan % 3 == 0 || cevre % 3 == 0)
                        {
                            Console.Write("NE ");
                        }

                        if (alan % 7 == 0 || cevre % 3 == 0)
                        {
                            Console.Write("TÜRKİYE");
                        }

                        if (alan % 15 == 0 || cevre % 15 == 0)
                        {
                            Console.Write("NE MUTLU");
                        }

                        if (alan % 21 == 0 || cevre % 21 == 0)
                        {
                            Console.Write("NE TÜRKİYE");
                        }

                        if (alan % 35 == 0 || cevre % 35 == 0)
                        {
                            Console.Write("MUTLU TÜRKİYE");
                        }

                        if (alan % 105 == 0 || cevre % 105 == 0)
                        {
                            Console.Write("MUTLU TÜRKİYE");
                        }
                        break;

                    case "q":
                        asdfg = false; // Döngüyü sonlandırır
                        break;

                    default:
                        Console.WriteLine("Geçersiz bir seçenek girdiniz.");
                        break;
                }

                Console.WriteLine("Devam etmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }
    }
}