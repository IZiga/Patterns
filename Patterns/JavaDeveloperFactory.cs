using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class JavaDeveloperFactory : DevloperFactory
    {
        public Devloper createDevloper()
        {
            return new JavaDevloper();
        }
    }
}
