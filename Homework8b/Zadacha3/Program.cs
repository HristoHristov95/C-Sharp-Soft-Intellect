using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean test=true;
            while (test)
            {
                String[] cards = new String[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "K", "Q", "A" };
                int[] numberOfAllCards = new int[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
                Random rand = new Random();
                List<String> kartite = new List<String>();
                int temp = 4;
                for (int i = 0; i < 5; i++)
                {
                    int numberForCard = rand.Next(0, 13);
                    temp = numberOfAllCards[numberForCard];
                    if (temp != 0)
                    {
                        kartite.Add(cards[numberForCard]);
                        temp--;
                        numberOfAllCards[numberForCard] = temp;
                    }
                    else
                    {
                        i--;
                    }
                }
                int counter = 0;
                List<int> results = new List<int>();
                for (int i = 0; i < 5; i++)
                {
                    String card = kartite.ElementAt(i);
                    for (int temporary = i + 1; temporary < 5; temporary++)
                    {
                        if (card.Equals(kartite.ElementAt(temporary)))
                        {
                            counter++;
                        }
                    }
                    results.Add(counter);
                    counter = 0;
                }
                Console.WriteLine("Here is your hand with cards :");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(kartite.ElementAt(i) + "  ");
                }
                for (int i = 0; i < results.Count; i++)
                {
                    if (results.ElementAt(i) == 3)
                    {
                        Console.WriteLine("Kare !");
                        test = false;
                        break;
                    }
                    if (results.ElementAt(i) == 2)
                    {
                        Console.WriteLine("Set !");
                        test = false;
                        break;
                    }
                }
            }
        }
    }
}
