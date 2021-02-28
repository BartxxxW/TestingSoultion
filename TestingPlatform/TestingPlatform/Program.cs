using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass.FirstExample();

            //NotExistingUser.Test();
            NotExistingUser.Setup();
            NotExistingUser.Test();
            NotExistingUser.TearDown();
            Console.ReadKey();
        }
    }
}
