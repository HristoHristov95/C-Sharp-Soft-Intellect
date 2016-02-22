using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;

namespace sampleProject
{
    public static class Calculations
    {
        public static double weekly()
        {
            double result = 0;
            try
            {
                List<String> list = DataManagement.readInfo();
                List<double> numbers = new List<double>();
                List<InfoClass> classList = new List<InfoClass>();
                for (int i = 0; i < list.Count; i++)
                {
                    String[] temp = list.ElementAt(i).Split('|');
                    InfoClass temp1 = new InfoClass(temp[0], temp[1], temp[2]);
                    classList.Add(temp1);
                }
                for (int i = 0; i < classList.Count; i++)
                {
                    DateTime time = DateTime.Parse(classList.ElementAt(i).Date);
                    DateTime timeToday = DateTime.Now;
                    DateTime timeMinusSeven = timeToday.AddDays(-7);
                    if (timeToday >= time && time >= timeMinusSeven)
                    {
                        double temporary = double.Parse(classList.ElementAt(i).Price);
                        result += temporary;
                    }
                }
            }catch(FileNotFoundException ex)
            {
                throw;
            }
            return result;

        }
        public static double monthly()
        {
            double result = 0;
            try
            {
                List<String> list = DataManagement.readInfo();
                List<double> numbers = new List<double>();
                List<InfoClass> classList = new List<InfoClass>();
                for (int i = 0; i < list.Count; i++)
                {
                    String[] temp = list.ElementAt(i).Split('|');
                    InfoClass temp1 = new InfoClass(temp[0], temp[1], temp[2]);
                    classList.Add(temp1);
                }
                for (int i = 0; i < classList.Count; i++)
                {
                    DateTime time = DateTime.Parse(classList.ElementAt(i).Date);
                    DateTime timeToday = DateTime.Now;
                    DateTime timeMinusSeven = timeToday.AddDays(-30);
                    if (timeToday >= time && time >= timeMinusSeven)
                    {
                        double temporary = double.Parse(classList.ElementAt(i).Price);
                        result += temporary;
                    }
                }
            }catch(FileNotFoundException exe)
            {
                throw;
            }
            return result;
        }
        public static double yearly()
        {
            double result = 0;
            try
            {
                List<String> list = DataManagement.readInfo();
                List<double> numbers = new List<double>();
                List<InfoClass> classList = new List<InfoClass>();
                for (int i = 0; i < list.Count; i++)
                {
                    String[] temp = list.ElementAt(i).Split('|');
                    InfoClass temp1 = new InfoClass(temp[0], temp[1], temp[2]);
                    classList.Add(temp1);
                }
                for (int i = 0; i < classList.Count; i++)
                {
                    DateTime time = DateTime.Parse(classList.ElementAt(i).Date);
                    DateTime timeToday = DateTime.Now;
                    DateTime timeMinusSeven = timeToday.AddDays(-365);
                    if (timeToday >= time && time >= timeMinusSeven)
                    {
                        double temporary = double.Parse(classList.ElementAt(i).Price);
                        result += temporary;
                    }
                }
            }catch(FileNotFoundException ex)
            {
                throw;
            }
            return result;
        }
    }
}