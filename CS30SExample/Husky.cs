using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** Required package class namespace */
namespace CS30SExample
{

    /// <summary>
    /// Husky.java - represents a Husky. This class uses inheritance to inherit
    /// the properties and methods from the Students class, which was already
    /// inheriting(extending) from the Person class. Therefore, this class
    /// inherits from both(a double inheritance).
    /// </summary>
    class Husky : Student
    {

        private bool pride;                          // encapsulated property


        /// <summary>
        /// Constructor for the class, sets the class properties to the default 
        /// values or the passed parameters
        /// </summary>
        /// <param name="name">the name of this Husky "is a" Student "is a" Person</param>
        /// <param name="age">the age of this Husky "is a" Student "is a" Person</param>
        /// <param name="gender">the gender of this Husky "is a" Student "is a" Person</param>
        /// <param name="number">the number of this Husky "is a" Student </param>
        public Husky(string name, int age, string gender, 
            int number) : base(name, age, gender, number)
        {
            this.pride = true;      // could have also been written "pride = true;"
        }

        /// <summary>
        /// Talking overrides the same talk method of the parent class (Student)
        /// and outputs additional information to the screen
        /// </summary>
        public void talk()
        {
            base.talk();       // call to super talk(), it calls super talk() also
            Console.WriteLine("\t\tPride is " + pride);
        }

    }
}
