using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.website
{
    class WebsiteTeamFactory : ProjectTeamFactory
    {
        public Developer getDeveloper()
        {
            return new PythonDeveloper();
        }

        public ProjectManager getProjectManager()
        {
            return new WebsitePM();
        }

        public Tester getTester()
        {
            return new ManualTester();
        }



        


    }
}
