using System;

namespace utsdaspro
{
    class nametag
    {
        static void Main(string[] args) {
            
            //Intro + Inisialisasi Variabel
            String namaDiri, nomor, konsen;
            Console.WriteLine("Nama : ");
            namaDiri = Console.ReadLine();
            Console.WriteLine("NIM :");
            nomor = Console.ReadLine();
            Console.WriteLine("Konsentrasi :");
            konsen = Console.ReadLine();
            
            //Tabel Mencetak NameTag
            Console.WriteLine("|***************************|");
            Console.WriteLine("{0, -8} {1,20}", "|Nama:", namaDiri+"|");
            Console.WriteLine("{0, -8} {1,20}", "|", nomor+"|");
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("{0, -8} {1,20}", "|", konsen+"|");
            Console.WriteLine("|***************************|");
        }
    }   
}