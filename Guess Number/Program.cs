using System;

namespace utsdaspro
{
    class tebakangka
    {
        static void Main(string[] args) {
        
            //Inisialisasi Variabel tebakAngka
            int answer = 0;
            Random rng = new Random();
            int rightAnswer = rng.Next(1,101);
            //Proses tebakAngka
            while (answer != rightAnswer)
            {
                Console.Write("Tebak angka dari 1-100: ");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer < rightAnswer)
                {
                    Console.WriteLine("Salah. Nilai terlalu rendah.");
                }
                else if (answer > rightAnswer)
                {
                    Console.WriteLine("Salah. Nilai terlalu tinggi.");
                }
                else
                {
                    Console.WriteLine("Anda benar!");
                    Console.WriteLine("Bye...");
                }
            }
        }
    }   
}
