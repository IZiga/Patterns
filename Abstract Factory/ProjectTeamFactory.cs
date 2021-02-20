using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    interface ProjectTeamFactory
    {
        Developer getDeveloper();
        Tester getTester();
        ProjectManager getProjectManager();
    }
}
