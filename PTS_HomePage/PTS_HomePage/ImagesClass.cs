using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PTS_HomePage
{
    public class ImagesClass
    {
        private string image;
        public ImagesClass(string img)
        {
            image = img;
        }
        public String Image { get { return image; } set { this.image = value; } }
    }
}