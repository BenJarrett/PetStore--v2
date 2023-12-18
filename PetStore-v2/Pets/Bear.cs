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
        public string EducationLevel { get; set; } /* = "GED";*/ // Default Value // - For every Bear that gets created // Can set it in the properties like this, or setting it in the constructor like I did //
        public Tiger BestTigerFriend { get; set; }
        public bool LovesHoney { get; } // Read Only Property - If we want this value to never change, remove the set // - Can only be set in the constructor, as many times as we want, but only in the constructor below. Once the Bear is created, it's only read only from that point forward. Cannot be changed. Still a public property is getable, but neither or some on the outside change it. //


        // Constructor Template Shortcut // - CTOR then tab twice
        // This is now the bare minumum needed to create this class //
        // Now you cannot create a Bear class without giving it these properties //
        // Can also have logic involved //
        public Bear(string name, string type)
        {
            Name = name;
            Type = type;
            EducationLevel = "GED"; // Setting the default value in the constructor //


            if (name == "Winnie the Pooh")
            {
                LovesHoney = true;
            }
            else if (name == "Yogi")
            {
                EducationLevel = "Above Average";
            }
        }

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
    }
}