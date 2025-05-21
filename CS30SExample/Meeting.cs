using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** Required package class namespace */
namespace CS30SExample
{

    /// <summary>
    /// Meeting.cs - represents a meeting. This class associates ("has a") with
    /// objects of the Person class (through an array). It uses the concept of 
    /// polymorphism to allow any Person objects or children (sub-classes) of the 
    /// Person class to be added to the array.
    /// </summary>
    class Meeting
    {

        private Person[] members;       // associate array of Person objects
        private int index;              // encapsulated counter for the array
        private const int MAX = 500;    // constants maximum members


        /// <summary>
        /// Default constructor, set the class properties to default values
        /// </summary>
        public Meeting() { 
            index = 0;                  // initializing (set to default value)
            members = new Person[MAX];  // initializing the array
        }

        /// <summary>
        /// Adds a person to the members (the encapsulated array) of the meeting
        /// </summary>
        /// <param name="person">the Person object to add</param>
        public void attend(Person person) { 
            members[index] = person;    // assigning the parameter to the array
            index++;                    // advance index to the next array location
            if (index >= MAX) index = 0;    // Error check the bounds of the array
        }

        /// <summary>
        /// Has all of the active members of the meeting talk
        /// </summary>
        public void hold() {
            Console.WriteLine("Meeting will now begin...");
            for (int i = 0; i < index; i++) {               // Loop through
                members[i].talk();                          // Have member talk
            }
        }

    }
}
