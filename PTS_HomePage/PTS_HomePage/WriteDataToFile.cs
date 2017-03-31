using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PTS_HomePage
{
    public class WriteDataToFile
    {
        public static void write_data(List<DataTemplate> l)
        {
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                using (StreamWriter wr = new StreamWriter("C:\\Users\\Hristo\\data.json", true))
                {
                    serializer.Serialize(wr, l);
                }
            }
            catch(FileNotFoundException ex)
            {
                throw;
            }
        }
    }
}