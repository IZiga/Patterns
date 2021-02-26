using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Director
    {
        public WebsiteBuilder builder { private get; set; }

        public Website buildwebsite() 
        {
            builder.createWebsite();
            builder.buildName();
            builder.buildCms();
            builder.buildPrice();


            Website website = builder.getWebsite();
            return website;
        }

       
    }
}
