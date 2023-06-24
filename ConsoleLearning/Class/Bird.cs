using C_8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_8.Clases
{
    public class Bird : Animals , IRun
    {

        public Bird()
        {
            typeAnimal = "";
            name = "";
        }
        public Bird(string btypeA, string nameB)
        {
            typeAnimal = btypeA;
            name = nameB;
        }

        public static void loop()
        {
            Console.WriteLine("Choose type");
            showType();
            string typeA = "";
            choose(typeA);
            ////                         //////
            Console.WriteLine("Give name to your animal");
            string name = Console.ReadLine();
            Bird bird = new Bird(typeA, name);
            ///////////////////////////////////
            ///
            Console.WriteLine("HI! I'm your bird - My name is: " + name);
            while (true)
            {
                if (feed == true) Console.WriteLine("If u want me to eat press 1.");
                else Console.WriteLine("I can't eat for now. I'm full");
                Console.WriteLine("If u want me to run press 2.");

                chooseAction(name);
            }
        }

        static void chooseAction(string name)
        {
            int select = Convert.ToInt16(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Eat(name);
                    break;
                case 2:
                    IRun.Run(name);
                    break;
            }
        }
        public static string choose(string type)
        {
            int choose = Convert.ToInt16(Console.ReadLine());
            switch (choose)
            {
                case 1: Console.WriteLine("You selected Songbird");
                    type = "Songbird";
                    break;
                case 2:
                    Console.WriteLine("You selected Sparrow");
                    type = "Sparrow";
                    break;
                case 3:
                    Console.WriteLine("You selected Starling");
                    type = "Starling";
                    break;
                case 4:
                    Console.WriteLine("You selected Swallow");
                    type = "Swallow";
                    break;
            }
            return type;
        }
        public static void showType()
        {
            var Birds = new List<string>()
            {
               "(1) Songbird",
               "(2) Sparrow",
               "(3) Starling",
               "(4) Swallow"
            };
            foreach(var b in Birds)
            {
                Console.Write(b + " ");
                Console.WriteLine("");
            }
        }
    }
}
