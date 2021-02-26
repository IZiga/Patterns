using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    abstract class WebsiteBuilder
    {
        protected Website website;

       public void createWebsite()
        {
            website = new Website();
        }

        public abstract void buildName();

        public abstract void buildCms();

        public abstract void buildPrice();

        public Website getWebsite()
        {
            return website;
        }

    }
}
