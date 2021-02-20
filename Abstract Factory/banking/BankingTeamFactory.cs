using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.banking
{
    class BankingTeamFactory : ProjectTeamFactory
    {
        public Developer getDeveloper()
        {
            return new JavaDeveloper();
        }

        public ProjectManager getProjectManager()
        {
            return new BankingPM();
        }

        public Tester getTester()
        {
            return new QATester();
        }
    }
}
