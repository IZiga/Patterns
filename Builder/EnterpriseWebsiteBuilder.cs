using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class EnterpriseWebsiteBuilder : WebsiteBuilder
    {
        public override void buildCms()
        {
            base.website.name = "Enterprise web site"; 
        }

        public override void buildName()
        {
            base.website.cms = Cms.Alifresco;
        }

        public override void buildPrice()
        {
            base.website.price = 10000;
        }
    }
}
