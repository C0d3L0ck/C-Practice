using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_8.Clases
{
    public class Animals
    {
        public string typeAnimal { get; set; }
        public string name { get; set; }

        public Animals()
        {
            this.typeAnimal = "";
            this.name = "";
        }
        public Animals(string tA, string n)
        {
            this.typeAnimal = tA;
            this.name = n;
        }

        public static bool feed = true;
        public static async void Eat(string nameA)
        {    
                if (feed == true) {
                Console.WriteLine(nameA + " is eating");
                feed = false;
                await Task.Delay(5000);
                    feed = true;
            }
        }
    }
}
