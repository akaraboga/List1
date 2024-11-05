using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//ArrayList için System.Collections kütüphanesini clasımıza ekliyoruz

namespace List1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList Kisiler = new ArrayList();//Kisiler adında listemizi olustuyoruz.

            Kisiler.Add("Bulent Ersoy");//Kisileri kisiler.Add ile listemizin içine ekliyoruz
            Kisiler.Add("Mustafa Topal");
            Kisiler.Add("Funda Arar");
            Kisiler.Add("Hande akalın");
            Kisiler.Add("Demet Yener");

            Console.WriteLine("Davetli lsitesi");

            

            for (int i = 1; i < Kisiler.Count; i++)//Ekrana bastırma.
            {
                Console.WriteLine($"{i} - {Kisiler[i]}");
            }

           
           

            Console.ReadKey();
        }
    }
}
