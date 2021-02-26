using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class VisitCardWebsiteBuilder : WebsiteBuilder
    {
        public override void buildCms()
        {
            base.website.name = "Visit card";
        }

        public override void buildName()
        {
            base.website.cms = Cms.WordPress;
        }

        public override void buildPrice()
        {
            base.website.price = 500;
        }
    }
}
