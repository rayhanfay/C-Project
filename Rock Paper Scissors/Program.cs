using System;

namespace utsdaspro
{
    class suitbatuguntingkertas
    {
        static void Main(string[] args)
        {
            //Inisialisasi Variabel Menang Kalah Seri
            int kondisiMenang = 0, kondisiKalah = 0, kondisiSeri = 0;
            char pemain = ' ';
            Random rng = new Random();
            
            //Batu Gunting Kertas
            while (pemain != 'e')
            {
                Console.WriteLine("Batu, Gunting, Kertas\n");
                Console.Write("Choose [b]atu, [g]unting, [k]ertas, or [e]xit: ");
                pemain = Convert.ToChar(Console.ReadLine());

                if (pemain == 'e')
                {
                    break;
                }

                int bot = rng.Next(1, 4);
                if (pemain == 'b')
                {
                    if (bot == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Seri.");
                        kondisiSeri++;
                    }
                    else if (bot == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Anda Menang.");
                        kondisiMenang++;
                    }
                    else if (bot == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Anda Kalah.");
                        kondisiKalah++;
                    }
                }
                else if (pemain == 'g')
                {
                    if (bot == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Anda Kalah.");
                        kondisiKalah++;
                    }
                    else if (bot == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Seri.");
                        kondisiSeri++;
                    }
                    else if (bot == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Anda Menang.");
                        kondisiMenang++;
                    }
                }
                else if (pemain == 'k')
                {
                    if (bot == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Anda Menang.");
                        kondisiMenang++;
                    }
                    else if (bot == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Anda Kalah.");
                        kondisiKalah++;
                    }
                    else if (bot == 3)
                    {
                        Console.WriteLine ("Komputer memilih kertas");
                        Console.WriteLine("Seri.");
                        kondisiSeri++;
                    }
                }
                //Skor Hasil Permainan Batu Gunting Kertas
                Console.WriteLine("Skor: "+kondisiMenang+" menang, "+kondisiKalah+" kalah, "+kondisiSeri+" seri");
                Console.WriteLine("Tekan Enter untuk melanjutkan permainan...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}