using System;
using System.Collections.Generic;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DevloperFactory devloperFactory = createdDevloperBySpecialty("Java");
            Devloper devloper = devloperFactory.createDevloper();

            devloper.writeCode();
        }

        static DevloperFactory createdDevloperBySpecialty(string specialty) 
        {
            specialty = specialty.ToLower();
            var test = new List<string>
            {
                "java",
                "c#"
            };
            
            if (specialty.Equals(test[0]))
            {
                return new JavaDeveloperFactory();
            }
            else if (specialty.Equals(test[1]))
            {
                return new CsharpDeveloperFactory();
            }
            else 
            {
                throw new ArgumentException($"{specialty} программиста нету");
            }
            
            
        }
    }
}
