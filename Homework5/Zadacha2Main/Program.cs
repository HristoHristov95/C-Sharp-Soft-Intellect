using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2Main 
{
    class Program
    {
        static void Main(string[] args) // tuka sa startira cqlata 2-ra zadacha 
        {
            KumZadacha2.Automobile[] auto = new KumZadacha2.Automobile[5];
            KumZadacha2Suv.SUV[] suv = new KumZadacha2Suv.SUV[5];
            Random rand=new Random();
            for(int i=0;i<5;i++)
            {
                auto[i] = new KumZadacha2.Automobile((rand.NextDouble() * (10 - 5) + 5), (rand.NextDouble() * (20000 - 10000) + 10000));
            }
            for (int i = 0; i < 5; i++)
            {
                int trueORfalse = rand.Next(0,2);
                if(trueORfalse==1)
                {
                    suv[i] = new KumZadacha2Suv.SUV(true, ((rand.NextDouble() * (20000 - 10000)) + 10000));
                }else
                {
                    suv[i] = new KumZadacha2Suv.SUV(false, (rand.NextDouble() * (20000 - 10000) + 10000));
                }
            }
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(auto[i].ToString());
                Console.WriteLine(suv[i].ToString());
            }
        }
    }
}
