using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_8.Interfaces
{
    public interface IRun
    {
        public static void Run(string name)
        {
            Console.WriteLine(name + " is running");
        }
    }
}
