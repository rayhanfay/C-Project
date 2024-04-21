using System;

namespace utsdaspro
{
    class dendabuku
    {
        static void Main(string[] args)
        {
            //Inisialisasi Variabel
            int dendaBuku = 0;
            int hariPinjam = 0;
            Console.Write("Input jumlah hari peminjaman : ");
            hariPinjam = int.Parse(Console.ReadLine());

            //Proses If Kisaran Waktu Peminjaman
            if (hariPinjam <= 5)
            {
                dendaBuku = 0;
            }
            else if (hariPinjam > 5 && hariPinjam <= 10)
            {
                dendaBuku = (hariPinjam - 5) * 10000;
            }
            else if (hariPinjam > 10 && hariPinjam <= 30)
            {
                dendaBuku = (hariPinjam - 10) * 20000 + 50000;
            }
            else if (hariPinjam > 30)
            {
                dendaBuku = (hariPinjam - 30) * 30000 + 50000 + 400000;
                Console.WriteLine("Keanggotaan anda dibatalkan.");
            }
            Console.WriteLine("Total denda : Rp." +dendaBuku);
        }       
    }
}