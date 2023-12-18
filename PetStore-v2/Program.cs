using PetStore_v2.Pets; // Imports are at a namespace level // - order doesn't matter //
using System;

namespace PetStore_v2
{
    class Program
    {
        // Static Means that it shared across all instances and is additive.  Bc it doesn't have one of the four access modifiers, it's implicitly private. Static will take/call things like the 'Bark' method, and can call it on a specific instance of the class.
        // Static members are shared across all of the instances. - what that means, is there is exactly one copy of the Bark() method that has to be shared accross all instances of the dog class. 
        // That causes side effects. Can no longer access any properties that are instanced properties. 

        // this methoid and property that is defined this way is known as an instance members // - Have to be called on instances of the class // 
        // Static means shared across all instances //

        // Private - implicitly private // - // Static - Not an instance method // - // Void - Doesn't return anything // - // Name - 'Main' // - // Param - T
        static void Main(string[] args)
        {
            // Obstantiate new variable = to a new isntance of our class dog // - bc we set the class properties and bc they are publicly accessible, we are now able access/do stuff with them
            // Now we can store this info on this instance of my Dog class //
            var melba = new Dog("Melba", 60, "Medium");
            melba.Bark();

            // Won't work - property is privately set // 
            // melba.Weight -= 15

            Console.WriteLine($"What type of food should {melba.Name} eat?");
            var typeOfFoodForMelba = Console.ReadLine();

            melba.Eat(typeOfFoodForMelba);

            // Won't work - Can't dynamically add properties to a class 
            /*melba.CoatType = "Short"*/

            var barley = new Dog("Barely", 50, "Medium");
            barley.Bark();

            barley.Eat("table scraps");

            // Object Initializer // - if you create a class and setting properties immidiately after you create the class. Almost always it is idiomatic to do this. //
            // Control . on the 3 dots under new. Changes the code a bit
            // Another way to immidialtely set the properties on a class
            // Not a constructor
            var tiger = new Tiger
            {
                Name = "Kisa",
                NumberOfKills = 0,
                Size = "Medium",
                Speed = 7,
            };

            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");

            var bear = new Bear("Yogi", "Brown");
            // bear.NumberOfFishEaten = 5; // Won't work bc this property is { get; private set; } Have to go through the class to change this property. // 
            // See the EatFish() method in the Bear class to see how to manipulate it //
            bear.EatFish(5);
            bear.EatFish(5);
            bear.EatFish(5);
            bear.EatFish(-5); // In this case, this what we don't want to allow. // In this case, we want rules around how many fish this can eat, and if we exposed it publicly, we would lose the control to create and manipulate these rules. In this case, we don't want this property to be able to move backwards.  // - The fish vomited 5 fish right back up // 
            // We want people to knoiw how many fish this bear has eaten, but don't want to allow them to manipulate however they want. In this case they can only add to how many fish the bear has eaten. //
            // The they in this case, is you in the future. //

            // 2nd constructor example //
            // bc we have two contructors on the bear clss, it will ask us which one we want to use //
            // Can 
            var bear2 = new Bear();
            // 2nd constructor example //

        }
    }
}