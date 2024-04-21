using System;

namespace DasPro
{
    class AduDadu
    {
            //Main Method    
            static void Main(string[] args)
            {    
                Intro();
                PlayGame();
                Outro();
            }

            static void Intro(){
                //Intro
                Console.WriteLine("------------------=Adu Dadu=------------------");
                Console.WriteLine("");
                Console.WriteLine("Pada game ini anda dan komputer akan bermain 10 ronde");
                Console.WriteLine("Setiap putaran dadu akan dilempar menghasilkan nilai tertentu");
                Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
                Console.WriteLine("Siapa yang akan menang? Selamat berjuang");
                Console.ReadKey();
            }
            
            static void PlayGame(){
                //Variabel
                int player;
                int komputer;

                int nilaiPlayer = 0;
                int nilaiKomputer = 0;
                
                //RNG
                Random random = new Random();
                Console.WriteLine(""); 
                Console.WriteLine("Mulai Main.....");

                //Loop 10x
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ronde " + i);
                    komputer = random.Next (1, 7);
                    Console.WriteLine("Nilai Komputer : " + komputer);
                    Console.WriteLine("Lempar dadu anda.... ");

                    Console.ReadKey();

                    player = random.Next(1, 7);
                    Console.WriteLine("Nilai anda : " + player);

                    if(player > komputer)
                    {
                        nilaiPlayer++;
                        Console.WriteLine("Anda memenangkan ronde ini");
                    }
                    else if(player < komputer)
                    {
                        nilaiKomputer++;
                        Console.WriteLine("Maaf anda kalah ronde ini");
                    }
                    else
                    {
                        Console.WriteLine("Ronde ini seri");
                    }

                    Console.WriteLine("Skor - Anda : " + nilaiPlayer + " Komputer : " + nilaiKomputer + "");
                    Console.WriteLine("Lanjut ke ronde berikutnya...");
                    
                    //Delay System
                    System.Threading.Thread.Sleep(1500);
                }

                //Input Nilai
                    Console.WriteLine("");
                    Console.WriteLine("Skor Akhir - Anda : " + nilaiPlayer + " Komputer : " + nilaiKomputer + "");
                    Console.WriteLine("Permainan Selesai");
                    
                if(nilaiPlayer > nilaiKomputer)
                {
                    Console.WriteLine("Selamat, Anda Menang!");
                }
                else if(nilaiPlayer < nilaiKomputer)
                {
                    Console.WriteLine("Maaf anda kalah, coba lagi");
                }
                else
                {
                    Console.WriteLine("Hasil seri, ayo coba lagi");
                }
                    Console.ReadKey();
            }
            static void Outro(){
                //Data Diri
                Console.WriteLine("");
                Console.WriteLine("Nama : Rayhan Al Farassy");
                Console.WriteLine("Nim  : 2207135776");
                Console.WriteLine("Tugas 3 Projek Game Adu Dadu");
            }
    }
}
