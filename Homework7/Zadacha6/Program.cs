using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            String pattern = "[.,?\\!\\;\\:\\-\\<\\>\\[\\]\\{\\}\\\"\\(\\)]";
            try
            {

                StreamReader reader = new StreamReader("text.txt");
                String text = reader.ReadToEnd();
                String[] textForWriting = Regex.Split(text, pattern, RegexOptions.IgnoreCase);
                StreamWriter writer = new StreamWriter("textRdy.txt");
                for (int i = 0; i < textForWriting.Length; i++)
                {
                    writer.WriteLine(textForWriting.ElementAt(i));
                }
                writer.Close();
            }catch(IOException e)
            {

            }
            catch (Exception e)
            {

            }
        }
    }
}
