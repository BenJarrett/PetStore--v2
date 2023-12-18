using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_v2.Pets
{
    class Tiger
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int NumberOfKills { get; set; }
        public short Speed { get; set; }



        // Fields // - For internal stuff
        // - Things that are for me that I need in order to do my job. But don't neccesarily need other people to know about //
        // - Used to stored data inside the class, but shouldn't be exposed externally to other people //
        // - Things we want to keep internally // 
        // Inplicitly private //
        // Can be thought of as a class level variable //
        // - Decalred almost exactly like a property // 
        // - Info I need, but not info that I want to share //
        // Naming fields is where one of the big differences are compared to Properties //
        // Pre-fixed with an underscore\, then camelCased. Conventional idiomatic naming //
        // No getter or setter. Almost works more like a variable //
        // Fields are instance level by default, unless you specifiy that it is static //

        // USE CASE OF STATIC FIELD //
        /*        - static int _numberOfBites;
                  - Then created 5 different Tigers and made them all bite people, we could use this to track how many bites there were across our entire population of Tigers */
        // USE CASE OF STATIC FIELD //
        // Fields //

        int _numberOfBites;


        // Every tiger starts off with one bite //
        public Tiger()

        {
            _numberOfBites = 1;
        }


        public void Bite(string handlerName)
        {
            _numberOfBites++;
            if (_numberOfBites is 5 or 10 or 15)
            {
                var incremenfOfFive = $"{Name} the tiger just bit {handlerName} again! That's the {_numberOfBites} time!";
                Console.WriteLine($"This is a bitey Tiger {incremenfOfFive}");
            }

            Console.WriteLine("This is a bitey Tiger");
        }
    }
}