using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PTS_HomePage
{
    public class ReadDataFromFile
    {
        public static List<DataTemplate> read_data()
        {
            List<DataTemplate> list;
            try
            {
                using (StreamReader rd = new StreamReader("C:\\Users\\Hristo\\data.json"))
                {
                    string allData=rd.ReadToEnd();
                    list = JsonConvert.DeserializeObject<List<DataTemplate>>(allData);
                }
            }
            catch (FileNotFoundException ex)
            {
                throw;
            }
            return list;
        }
    }
}