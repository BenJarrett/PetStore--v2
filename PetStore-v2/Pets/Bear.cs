using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_v2.Pets
{
    class Bear
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int NumberOfFishEaten { get; private set; } // Can't make the number of fish eaten on a Bear class increas or decrease, there are rules on how we change the number of fish a bear has eaten. Can Get, or read this property as much as you want, but only I can make a change to it // No one else means me in the future I guess. So like if I, later, am the Program.cs class, I can't change that value from there. Can only get it.
        public string EducationLevel { get; set; } /* = "GED";*/ // Default Value // - For every Bear that gets created // Can set it in the properties like this, or setting it in the constructor like I did // See Program.cs file for an example use case of this //
        public Tiger BestTigerFriend { get; set; } // Property called BestTigerFriend, that will store an istance of the Tiger Class // 

        // *** Two ways of setting this. Can use Expression Bodies Property like I did below  *** // 
        // *** public bool LovesHoney { get; } *** OR like I did below // Read Only Property - If we want this value to never change, remove the set // - Can only be set in the constructor, as many times as we want, but only in the constructor below. Once the Bear is created, it's only read only from that point forward. Cannot be changed. Still a public property is getable, but neither or some on the outside change it. //
        // If we know that the only bear that loves honey is Winnie the Pooh, we can say that if this LovesHoney should return True or not, if true the name property is Winnie the Pooh.  //
        // This is now a function that returns a bool, that is set to our property of LovesHoney //
        // This function doesn't actually return anything, but it sets a value //
        // Still a get only property, but this function is the getter now // 
        // Generally, there is a very limited use case for this //
        public bool LovesHoney => Name == "Winnie the Pooh"; // -  *** Ecpression Bodies ReadOnly Property *** //
        // *** Two ways of setting this. *** //


        // Constructor Template Shortcut // - CTOR then tab twice
        // This is now the bare minumum needed to create this class //
        // Now you cannot create a Bear class without giving it these properties //
        // Can also have logic involved //
        // Mostly Used for establishing defaults and minumum requirements for a copy //
        public Bear(string name, string type)
        {
            Name = name;
            Type = type;
            EducationLevel = "GED"; // Setting the default value in the constructor


            //if (name == "Winnie the Pooh")
            //{
            //    LovesHoney = true;
            //}
            if (name == "Yogi")
            {
                EducationLevel = "Above Average";
            }
        }


        // *** CONSTRUCTOR OVERLOADING *** //
        // If you wanted to be able to have multiple ways to build a class, you can do that //
        // If I wanted a constructor take in Name and Type, but in additon wanted it to take in Name Type and Education Level. I can create a second constructor //
        // Ususally you'll find that if they're the same, you'll want to keep them in the same place/order. //
        // Now I have two constructors, one that takes in name, type, and educationLevel, and one that takes in name and type. // 
        // See Program.cs file for bear2 example of this being used //
        // Can work completely different or collboritvely //
        // In the Bear constructor below, we are first calling the constructor above, and then using ours to use them in collaboration. // 
        // : colon says, I am about to do something prior to doing this contrsuctor //
        // I would like to call the constructor that looks like this other one, into the constructor of this class // 
        // Setting the class property value to the educationLevel param in the contrsuctor below //
        // *** CONSTRUCTOR OVERLOADING *** //

        public Bear(string name, string type, string educationLevel) : this(name, type)
        {
            EducationLevel = educationLevel;
        }

        // In this one, we want this Bear to have started out already having eaten fish, but I also want to take in how many fish this bear ate. // 
        // First talks to the constructor with three params, then that will so no no, first talk to the one with two params, then the code is executed asynchonysly //
        // We are saying that we want to set the numberOfFishEaten to be whatever amount the param howManyFish is //
        // Basically we are extending or building on top of the other constructors //
        // *** EXPRESSION BODIED MEMBERS *** //
        // Another way of writing a simple, one liner with curly brackets like above. It's just a cleaner way to do it. // 
        // Member - Any part of a class - Method, Property or Field //
        // Expression - Very similar concept to Inline function - In JS, they are called fat arrow functions //
        // Can take any of the one liners, and instead of them being a full member, I can turn them into an expression bodied member  //
        // Functionally the same as the part that is commented out. //
        // In this case it is an Expression Bodied Constructor, specifically //
        public Bear(string name, string type, string educationLevel, int howManyFish) : this(name, type, educationLevel) => NumberOfFishEaten = howManyFish;
        /*       {
                   NumberOfFishEaten = howManyFish;
               }*/
        // *** EXPRESSION BODIED MEMBERS/CONSTRUCTORS *** //



        // **Encapsulation** // - Taking your job and hiding it from other people so they don't have to worry about how it works- There are rules behind this behavior, but no one else but the Bear has to worry about what those rules are // **
        // This is saying whoever calls this is going to tell this method how many fish the bear has eaten. 
        // Adding the amount of fish the int says (howMany) to the property of NumberOfFishEaten. We can do this bc we are inside the class.// 
        // In this case, this what we don't want to allow. // In this case, we want rules around how many fish this can eat, and if we exposed it publicly, we would lose the control to create and manipulate these rules. In this case, we don't want this property to be able to move backwards.  // - The fish vomited 5 fish right back up // 
        // We want people to knoiw how many fish this bear has eaten, but don't want to allow them to manipulate however they want. In this case they can only add to how many fish the bear has eaten. //
        // The they in this case, is you in the future. //
        // See Program.cs for an example of how we don't want them to manipulate this field. //

        // Because we are writing these rules at this class level, I now know that everytime  fish get eaten, they have to follow these rules. 
        // Every Bear has to follow these same rules. That's good bc I don't have to write a bunch of times in a bunch of different places //
        // **Encapsulation** // - Taking your job and hiding it from other people so they don't have to worry about how it works // **
        public void EatFish(int howMany)
        {
            if (howMany <= 0) return; // If howMany is less than or equal to 0, let's bail out and not let them run the rest of the method. //

            NumberOfFishEaten += howMany;
        }

        // Bear.cs property BestTigerFriend method Example //
        // Deals with the data from this bear's class, and going to look at the instance of the tiger class we are passing in that is theBestTigerFriend  //
        public void HangOutWithBestFriend()
        {
            var output = $"{Name} the bear is hanging out with" +
                $" it's best tiger friend, {BestTigerFriend.Name}" +
                $" the {BestTigerFriend.Size} sized tiger";

            Console.WriteLine(output);
        }
        // Bear.cs property BestTigerFkriend method Example // 
    }
}