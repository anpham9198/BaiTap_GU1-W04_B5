using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_GU1_W04_B5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar1 = { 1,2,3,4,5,0,0,0,0 };
            Console.WriteLine("Mang");

            foreach (int i in ar1)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            Console.Write("Nhap so ban muon chen: ");
            int insert = Int32.Parse(Console.ReadLine());

            Console.Write("Nhap vi tri ban muon chen: ");
            int index = Int32.Parse(Console.ReadLine());

            int[] ar2 = new int[10];
            for (int i = 0; i < ar1.Length; i++)
            {
                if (i == index)
                {
                    ar2[i] = insert;
                }
                else
                {
                    if (i >= index)
                    {
                        ar2[i] = ar1[i - 1];
                    }
                    else
                    {
                        ar2[i] = ar1[i];
                    }                                    
                }
            }
            Console.WriteLine("Mang moi sau khi chen");
            foreach (int i in ar2)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
