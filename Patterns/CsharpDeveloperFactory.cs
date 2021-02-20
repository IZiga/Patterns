using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class CsharpDeveloperFactory : DevloperFactory
    {
        public Devloper createDevloper()
        {
            return new CsharpDeveloper();
        }
    }
}
