using System;
using System.Linq;

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
                Console.WriteLine("Toplama (t)çıkarma (c) çarpma (x) bölme (b) yüzde işlemi (y) kar hesaplama (k) dikdörtgen hesaplama (d) yuzyil hesaplama(yy) array target(a) siralama(s)");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "t":
                        toplama();
                        break;

                    case "c":
                        cikarma();
                        break;

                    case "x":
                        carpma();
                        break;

                    case "b":
                        bolme();
                        break;

                    case "y":
                        yuzdeislemi();
                        break;

                    case "k":
                        kar();
                        break;

                    case "d":
                        dikdortgen();
                        break;
                    case "yy":
                        yuzyil();
                        break;
                    case "a":
                        dizi();
                        break;
                    case "s":
                        siralama();
                        break;
                    case "q":
                        asdfg = false;
                        break;

                    default:
                        Console.WriteLine("Geçersiz bir seçenek girdiniz.");
                        break;
                }

                Console.WriteLine("Devam etmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }

        static void toplama()
        {
            Console.WriteLine("1. sayı");
            int top1;
            if (!int.TryParse(Console.ReadLine(), out top1))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            Console.WriteLine("toplanacak 2. sayi");
            int top2;
            if (!int.TryParse(Console.ReadLine(), out top2))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            int toplam = top1 + top2;
            Console.WriteLine("cevap " + toplam);

            mutluturkiye(toplam);
        }

        static void cikarma()
        {
            Console.WriteLine("büyük sayıyı yaz");
            int sayi1;
            if (!int.TryParse(Console.ReadLine(), out sayi1))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            Console.WriteLine("küçük sayıyı yaz");
            int sayi2;
            if (!int.TryParse(Console.ReadLine(), out sayi2))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            int fark = sayi1 - sayi2;
            Console.WriteLine("cevap " + fark);

            mutluturkiye(fark);
        }

        static void carpma()
        {
            Console.WriteLine("ilk sayıyı yaz");
            int carp1;
            if (!int.TryParse(Console.ReadLine(), out carp1))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            Console.WriteLine("ikinci sayıyı yaz");
            int carp2;
            if (!int.TryParse(Console.ReadLine(), out carp2))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            int carpcevap = carp1 * carp2;
            Console.WriteLine("Sonuç: " + carpcevap);

            mutluturkiye(carpcevap);
        }

        static void bolme()
        {
            Console.WriteLine("İlk sayıyı yaz");
            int bol1;
            if (!int.TryParse(Console.ReadLine(), out bol1))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            Console.WriteLine("ikinci sayıyı yaz");
            int bol2;
            if (!int.TryParse(Console.ReadLine(), out bol2))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            if (bol2 == 0)
            {
                Console.WriteLine("bir şeyi 0'a bölemezsin");
                return;
            }

            double bolum = (double)bol1 / bol2;
            Console.WriteLine("cevap " + bolum);

            mutluturkiye(bolum);
        }

        static void yuzdeislemi()
        {
            Console.WriteLine("sayıyı yaz");
            int yuzde1;
            if (!int.TryParse(Console.ReadLine(), out yuzde1))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            Console.WriteLine("sayinin % kaçı alınacak");
            int yuzde2;
            if (!int.TryParse(Console.ReadLine(), out yuzde2))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            double cevapyuzde = (double)yuzde1 * yuzde2 / 100;
            Console.WriteLine("cevap " + cevapyuzde);

            mutluturkiye(cevapyuzde);
        }

        static void kar()
        {
            Console.WriteLine("ürünü aldığın fiyatı yaz");
            int alis;
            if (!int.TryParse(Console.ReadLine(), out alis))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            Console.WriteLine("ürünü sattığın fiyatı yaz");
            int satis;
            if (!int.TryParse(Console.ReadLine(), out satis))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            int kar = alis - satis;
            Console.WriteLine("kâr " + kar);

            mutluturkiye(kar);
        }

        static void dikdortgen()
        {
            Console.WriteLine("uzun kenarı yaz");
            int uzunk;
            if (!int.TryParse(Console.ReadLine(), out uzunk))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            Console.WriteLine("dikdörtgenin kısa kenarını yaz");
            int kisak;
            if (!int.TryParse(Console.ReadLine(), out kisak))
            {
                Console.WriteLine("sayı girmen lazım");
                return;
            }

            int alan = uzunk * kisak;
            int cevre = (uzunk + kisak) * 2;

            Console.WriteLine("alan " + alan);
            Console.WriteLine("cevre " + cevre);

            mutluturkiye(alan);
            mutluturkiye(cevre);
        }

            static void yuzyil()
            {
                Console.WriteLine("bir yil gir");
                if (!int.TryParse(Console.ReadLine(), out int yuzyil))
                {
                    Console.WriteLine("Geçerli bir yıl giriniz.");
                    return;
                }

                int yy = (yuzyil + 99) / 100;


                Console.WriteLine("{0}. yüzyıl", yy);
                mutluturkiye(yy);
            }
        
            static void dizi()
            {
                Console.Write("Kaç elemanlı bir dizi oluşturmak istiyorsunuz ");
                int sayiadedi = Convert.ToInt32(Console.ReadLine());

                int[] array = new int[sayiadedi];

                for (int i = 0; i < sayiadedi; i++)
            {
                Console.Write($"{i+1}. elemanı gir ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

                Console.Write("targeti yaz ");
                int target = Convert.ToInt32(Console.ReadLine());
                bool found = false;

                for (int i = 0; i < sayiadedi; i++)
            {
                for (int j = i + 1; j < sayiadedi; j++)
            {
                if (array[i] + array[j] == target)
                {
                    Console.WriteLine($"Dizideki elemanlar {i} ve {j} toplamı {target} ediyor.");
                    found = true;
                }
            }
            }

                if (!found)
                {
                    Console.WriteLine("herhangi iki sayı targeti vermiyor");
                }
    }

    static void siralama()
            {
                Console.Write("Kaç elemanlı bir dizi oluşturmak istiyorsunuz ");
                int sayiadedi = Convert.ToInt32(Console.ReadLine());

                int[] array = new int[sayiadedi];

                for (int i = 0; i < sayiadedi; i++)
            {
                Console.Write($"{i+1}. elemanı gir ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

                int min = array.Min(); 
                int max = array.Max(); 

                Console.WriteLine($"Dizideki en küçük eleman {min} ve en büyük eleman {max}");
                
    }




    static void mutluturkiye(int value)
        {
            if (value % 15 == 0)
                Console.Write("NE MUTLU ");

            if (value % 3 == 0)
                Console.Write("NE ");

            if (value % 7 == 0)
                Console.Write("TÜRKİYE");

            if (value % 21 == 0)
                Console.Write("NE TÜRKİYE");

            if (value % 35 == 0)
                Console.Write("MUTLU TÜRKİYE");

            if (value % 105 == 0)
                Console.Write("MUTLU TÜRKİYE");

            Console.WriteLine();
        }

        static void mutluturkiye(double value)
        {
            if (value % 15 == 0)
                Console.Write("NE MUTLU ");

            if (value % 3 == 0)
                Console.Write("NE ");

            if (value % 7 == 0)
                Console.Write("TÜRKİYE");

            if (value % 21 == 0)
                Console.Write("NE TÜRKİYE");

            if (value % 35 == 0)
                Console.Write("MUTLU TÜRKİYE");

            if (value % 105 == 0)
                Console.Write("MUTLU TÜRKİYE");

            Console.WriteLine();
        }
    }
}
