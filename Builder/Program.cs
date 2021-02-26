using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            director.builder = new EnterpriseWebsiteBuilder();

            Website website = director.buildwebsite();
            Console.WriteLine(website);

            Console.ReadLine();



        }
    }
}
