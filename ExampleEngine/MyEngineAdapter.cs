using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ExampleEngine
{
    public class MyEngineAdapter : IEngine
    {
        public bool QuitApplication()
        {
            Console.WriteLine("Application Quit Succesfully!");
            return true;
        }

        public bool StartApplication()
        {
            Console.WriteLine("Application Started Successfully!");
            return true;
        }
    }
}
