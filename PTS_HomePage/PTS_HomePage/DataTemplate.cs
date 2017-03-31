using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PTS_HomePage
{
    public enum engine_type { Diesel, Petrol, Gas };
    public class DataTemplate
    {
        private string car_brand;
        private string car_model;
        private string seller_number;
        private string year_of_production;
        private string kilometer_count;
        private engine_type type;
        private int horse_power;
        private string region_name;
        private List<ImagesClass> path_to_images;
        public DataTemplate(string cb, string cm, string sn, string yop, string kc, engine_type et, int hp, string rn,List<ImagesClass> pti)
        {
            car_brand = cb;
            car_model = cm;
            seller_number = sn;
            year_of_production = yop;
            kilometer_count = kc;
            type = et;
            horse_power = hp;
            region_name = rn;
            path_to_images = pti;
        }
        public String Car_Brand { get { return this.car_brand; } set { this.car_brand = value; } }
        public String Car_Model { get { return this.car_model; } set { this.car_model = value; } }
        public String Seller_Number { get { return this.seller_number; } set { this.seller_number = value; } }
        public String Year_Of_Production { get { return this.year_of_production; } set { this.year_of_production = value; } }
        public String Kilometer_Count { get { return this.kilometer_count; } set { this.kilometer_count = value; } }
        public engine_type Type { get { return this.type; } set { this.type = value; } }
        public int Horse_Power { get { return this.horse_power; } set { this.horse_power = value; } }
        public String Region_Name { get { return this.region_name; } set { this.region_name = value; } }
        public List<ImagesClass> Path_To_Images { get { return this.path_to_images; } set { this.path_to_images = value; } }
    }
}