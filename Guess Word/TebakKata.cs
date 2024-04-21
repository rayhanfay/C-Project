// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace TebakKata
{
    class Program
    {
            static int kesempatan = 5;
            static string kataRahasia ="naruto";
            static List<string> tebakanPemain = new List<string>{};
        static void Main(string[] args)
        {

            Intro();
            PlayGame();
            Outro();
        }
        static void Intro(){
            Console.WriteLine("Selamat Datang, hari ini kita akan bermain tebak kata...");
            Console.WriteLine($"Kamu punya {kesempatan} kesempatan untuk menebak kata misteri hari ini.");
            Console.WriteLine("Petunjuknya adalah kata ini merupakan judul anime.");
            Console.WriteLine($"Kata tersebut terdiri dari {kataRahasia.Length} huruf.");
            Console.WriteLine("Anime apakah yang dimaksud?");
            Console.ReadKey();           
        }

        static void PlayGame(){
            while (kesempatan>0)
            {
                Console.WriteLine("Apa huruf tebakanmu?(pilih a-z) : ");
                string input = Console.ReadLine();
                tebakanPemain.Add(input);
                if (cekJawaban(kataRahasia,tebakanPemain)){
                    Console.WriteLine("Selamat anda berhasil menebak katanya");
                    Console.WriteLine($"Kata misteri hari ini adalah {kataRahasia}");
                    Console.WriteLine("Terimakasih sudah bermain..");
                    Console.WriteLine("Nama : Rayhan Al Farassy");
                    Console.WriteLine("NIM : 2207135776");
                    break;
                }else if (kataRahasia.Contains(input)){
                    Console.WriteLine("Huruf itu ada di dalam kata ini");
                    Console.WriteLine(cekHuruf(kataRahasia,tebakanPemain));
                    Console.WriteLine("Silahkan tebak huruf lainnya...");

                }else{
                    Console.WriteLine("Huruf itu tidak ada dalam kata ini");
                    kesempatan--;
                    Console.WriteLine($"Kesempatan anda tinggal {kesempatan}");
                }

                }
            }
            static bool cekJawaban(string kataRahasia, List<string> List){
                    bool status = false;

                    for (int i = 0; i < kataRahasia.Length; i++){
                        string c = Convert.ToString(kataRahasia[i]);
                        if(List.Contains(c)){
                            status = true;
                        }else{
                            return status = false;
                        }
                    }
                    return status;
        }
            static string cekHuruf(string kataRahasia, List<string> List){
                string x = "";

                for (int i = 0; i < kataRahasia.Length; i++)
                {
                    string c = Convert.ToString(kataRahasia[i]);
                    if (List.Contains(c)){
                        x += c;
                    }else{
                        x += "_";
                    }
                    
                }

                return x;
            }
        static void Outro(){
            if (kesempatan==0){
            Console.WriteLine("Mohon maaf kesempatan anda habis");
            Console.WriteLine($"kata misteri yang dimaskud adalah {kataRahasia}");
            Console.WriteLine("Terimakasih sudah bermain..");
            Console.WriteLine("Nama : Rayhan Al Farassy");
            Console.WriteLine("NIM : 2207135776");
            }
        }
    }
}
