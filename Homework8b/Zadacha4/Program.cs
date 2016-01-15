using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            int arr0 = 1, arr1 = 2;
            List<long> listArr0 = new List<long>();
            List<long> f2 = new List<long>();
            List<long> f3 = new List<long>();
            listArr0.Add(arr0);
            f2.Add(arr1);
            f3.Add(arr1);
            // do utre nema go smetne tva sus 1 000 000 + tova toq long prevurta-> taka 4e go praa do 50
            for(int i=1;i<50;i++)
            {
                listArr0.Add(((2*listArr0.ElementAt(i-1))+3));
                f2.Add(((3*f2.ElementAt(i-1))+1));
                f3.Add(((2*f3.ElementAt(i-1))-1));
            }
            // obedinenie
            HashSet<long> obedinenie = new HashSet<long>();
            for(int i=0;i<50;i++)
            {
                obedinenie.Add(listArr0.ElementAt(i));
                obedinenie.Add(f3.ElementAt(i));
            }
            //se4enie
            HashSet<long> sechenie = new HashSet<long>();
            for(int i=0;i<50;i++)
            {
                if(listArr0.Contains(f3.ElementAt(i)))
                {
                    sechenie.Add(f3.ElementAt(i));
                }
            }
            Console.WriteLine("Obedinenie : ");
            for(int i=0;i<obedinenie.Count;i++)
            {
                Console.WriteLine(" " + obedinenie.ElementAt(i) + " ");
            }
            Console.WriteLine("Se4enie : ");
            for(int i=0;i<sechenie.Count;i++)
            {
                Console.WriteLine(" " + sechenie.ElementAt(i) + " ");
            }
        }
    }
}
