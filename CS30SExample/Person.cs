using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** Required package class namespace */
namespace CS30SExample
{

    /// <summary>
    /// Person.cs - represents a person. This is a class with properties (things
    /// about the class, adjectives, descriptors) and methods (things the class 
    /// can do, verbs, actions). Classes can be created (instantiated) into 
    /// objects (which are instances of that class).
    /// </summary>
    class Person
    {
        // Properties: (things about it, adjectives, descriptors, variables, arrays)

        // We add a keyword to the front of the properties (modifier word) to
        // determine if the property (variable, global variable) is encapsulated
        // or not. Meaning is the variable accessable (can be read and changed)
        // inside the class and/or outside the class (words "private" and "public")

        public String name;

        private int age;

        public String gender;

        private bool alive;

        // Methods: (things it can do, verbs, actions, return, parameter(s))

        /**
         * 
         */

        /// <summary>
        /// Constructor method is a special method that has:
        ///     (1) the same name as the class
        ///     (2) the name starts with a capital letter
        ///     (3) it has NO return type (not even the word "void")
        /// These methods are called when the class is used to build (construct, 
        /// instantiate) an object. We previously had a "born()" method that did 
        /// this, that we changed it into this constructor method. This method 
        /// "brings the person to life" meaning it is used when the class is used to
        /// create a Person object. The method sets all the class properties (global
        /// variables) to their starting values ("defaults").
        /// </summary>
        public Person()
        {
            alive = true;
            age = 0;
            name = "undefined";
            gender = "undefined";
        }

        // This method was originally written and then deleted (commented out)
        // because the new constructor method performs the same purpose....

        // void born() {
        //     alive  = true;
        //     age    = 0;
        //     name   = "undefined";
        //     gender = "undefined";        
        // }

        /// <summary>
        /// Constructor method, sets the class properties. Constructor methods 
        /// should be public
        /// </summary>
        /// <param name="newName">the new name for this person</param>
        public Person(string newName)
        {
            alive = true;
            age = 0;
            name = newName;
            gender = "undefined";
        }

        /// <summary>
        /// Overloaded (methods with the same name, different parameters) 
        /// constructor method, sets the class properties. Constructor methods with
        /// NO parameters are called default constructors
        /// </summary>
        /// <param name="name">the name of this person</param>
        /// <param name="age">the age of this person</param>
        /// <param name="gender">the identified gender of this person</param>
        public Person(string name, int age, string gender)
        {
            alive = true;
            // Assign the parameter to the property (global variable of this class)
            // To do this, we use the keyword "this" which acts as a placeholder
            // for the name of the object (which will be created at a later time)
            this.age = age;
            this.name = name;
            this.gender = gender;
        }

        /// <summary>
        /// The person dies (changing/modifying) the property (alive) through
        /// this method
        /// </summary>
        public void die()
        {
            alive = false;
        }

        /// <summary>
        /// Outputs information about the person to the screen
        /// </summary>
        public void talk()
        {
            if (alive == true)
            {
                Console.WriteLine(name + " is " + age + " identifes as " + gender);
            }
            else
            {
                Console.WriteLine("Boooooooo!");
            }
        }

        /// <summary>
        /// This method is a private method means it can be called (invoked)
        /// inside the class by other methods of the class. Private methods are
        /// rare and sometimes called "helper" or "utility" methods as they just 
        /// help other methods. Gives the person a birthday
        /// </summary>
        private void birthday()
        {
            age++;
        }

        /// <summary>
        /// Gives the person a birthday, changes the encapsulated property (age).
        /// This is a overloaded method meaning multiple methods with the same 
        /// name but different parameters.
        /// </summary>
        /// <param name="age">home many birthdays to give the person</param>
        public void birthday(int age)
        {
            for (int i = 0; i < age; i++)
            {
                birthday();
            }
            // or you could just write...
            // this.age = age;
        }

    }
}
