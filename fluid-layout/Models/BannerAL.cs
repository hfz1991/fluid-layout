using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fluid_layout.Models
{
    public class BannerAL
    {
        public BannerLine getBanner()
        {
            BannerLine banner = new BannerLine();
            banner.firstLine = "SIGN UP FOR DEALS,";
            banner.secondLine = "LATEST NEWS & MORE";
            
            return banner;
        }
    }
}