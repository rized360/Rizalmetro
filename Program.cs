using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

public class Program
{   
    public static void Main(String[] args)
    {
        while (true)
        {
            Console.WriteLine("Pilih satu menu...");
            Console.WriteLine("1. Cek IPK");
            Console.WriteLine("2. Cek Kelulusan");
            Console.WriteLine("0. Exit");

            int option = int.Parse(Console.ReadLine());

            Console.Clear();

            if (option == 0)
            {
                break;
            }

            switch(option)
            {
                case 1:
                   cekGpa();
                   break;
                case 2:
                   cekLulus();
                    break;
            }
            
            void cekGpa()
            {
                Console.Write("Nama Mahasiswa : ");
                string nama = Console.ReadLine();

                int[] gpaArray = new int[8];

                for (int i = 0; i < gpaArray.Length; i++)
                {
                    double gpa;
                    bool parseOkay;

                    Console.Write("Masukan IPS Semester {0}: ", i+1);
                    parseOkay = double.TryParse(Console.ReadLine(),out gpa);

                    while(parseOkay != true) 
                    {
                        Console.WriteLine("IPS Salah. Coba Lagi: ");
                        parseOkay = double.TryParse(Console.ReadLine(),out gpa);
                    }

                    gpaArray[i] = (int)gpa;

                }

                int sumGpa = 0;

                for (int i = 0;i < gpaArray.Length;i++)
                {
                    sumGpa = sumGpa + gpaArray[i];
                }

                double gpaPercent = ((double)sumGpa / 8);
                Console.WriteLine(" ");
                Console.WriteLine("Nama Mahasiswa : " + nama);
                Console.WriteLine("IPK Kamu : {0}", gpaPercent);
                Console.WriteLine(" ");

            }

            void cekLulus()
            {   
                Console.Write("Masukan IPK : ");
                double ipk = Convert.ToDouble(Console.ReadLine());

                if (ipk >= 2.25)
                {
                    Console.WriteLine("Kamu Lulus!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Kamu belum lulus!");
                    Console.WriteLine("x");
                }
            }

        }
    }
}
