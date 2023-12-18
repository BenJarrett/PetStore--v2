using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Parts of a class //

// 1. Methods - Behavior //
// - Alot of use from classes comes from having behviour on them // 
// - Roughly equivilant to functions in JS // 
// - Just like properties, there is kind of a formula to how you write methods // 
// -- Uses a METHOD SIGNATURE // - The way a method is defined //
// --- There are 4 parts to a method signature // 
// ---- Access Modifier // 
// ---- Return Type // - What Kind of thing this returns -- Could be any of types we talked about ex. string, ints, list. In the event you don't want to return anything there is a return type for that ex 'void' //
// ---- Name //
// ---- Param or list of parametes -If there is any // If you want to take in a param, you have to say what type of thing it is //

// 2. Statefulness - Poperties //
// - Made up of different things //
// -- Accessibility(Access) modifiers //- Who has access to this property - Most properties are going to be public / - Private it is the default/implicent if not specficed //
// -- Public means everyone can see it EX. Fur Color //

// - What kind of thing it is. Ex Size- What kind of data stores size info //
// --Properties are capitalized //
// --At the Class level the only three things you can do are - Define Properties - Define Fields - Define Methods //
// --Different types in C# have different values if you don't set them //

// 3. Fields - Internal Data - things you can't really see from the outside // 

namespace PetStore_v2.Pets
{
    // Class names are capitalized //
    class Dog // Implicitly internal unless specified //
    {
        // Properties // - Usually defined at the top of the class // - Ways to store bits of info about a thing // - For exposing stuff
        //- Access Modifier// - Type of property // - Name of property // - { get; set; }
        // -- Private: Only things in this class can use it // Private is the implcit or default access modifier //
        // -- Public: Everything that can see the class can access it //
        // --Internal: Anything in this project can access it // - useful for writing tools for other devs to use. If you want to hide stuff from other devs for you //
        // --Protected: anything that inherits from me can access //
        // - Things that are info about me, but stuff other that people may want to see or update //

        //Proprties
        //access modifier, type, name
        public string Size { get; set; } // auto-property
        public short Weight { get; private set; }
        public string Name { get; set; }


        // Constructor, Constructor Method //
        // specialized kind of method
        // access modifier
        // return type and name method combined into one. Has to be the same as the name of the type you are constructing
        // Constructors are made to take information. 
        // Once we take this information in on our constructor, it becomes a requirement of creating a new instance of that class.
        // A lot of time they are used for what the bare minimum requirements are for creating a copy of that class
        // Constructor, Constructor Method //
        public Dog(string name, short weight, string size)
        {
            Name = name;
            Weight = weight;
            Size = size;
        }


        // Method // 
        // -- Access Modifier // -See notes above //

        // -  Method Signature // 
        // -- Return Type // - In this case we don't want to return anything so it's 'void' //
        // -- Name // 
        // -- Param(s) // - If you want to take in a param, you have to say what type of thing it is //
        // Whatever way you set this method up, that's exactly the way this method has to be called. //
        public void Bark()
        {
            Console.WriteLine($"{Name} barks loudly");
        }

        public void Eat(string typeOfFood)
        {
            /*if (typeOfFood.ToLower() == "healthy food")*/
            // or //
            /*if (string.Equals(typeOfFood, "healthy food", StringComparison.OrdinalIgnoreCase))*/
            if (string.Equals(typeOfFood, "healthy food", StringComparison.OrdinalIgnoreCase))
            {
                Weight -= 1;

            }

            Console.WriteLine($"{Name} just ate {typeOfFood}. {Name} weighs {Weight}.");
        }

    }
}