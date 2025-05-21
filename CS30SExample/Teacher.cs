using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** Required package class namespace */
namespace CS30SExample
{

    /// <summary>
    /// Teacher.cs - represents a Teacher. This class uses inheritance to inherit
    /// the properties and methods from the Person class. This class also 
    /// "associates" with the Student class by making a reference to them within 
    /// the class. This is sometimes simplified as a "has a" relationship.
    /// </summary>
    class Teacher : Person
    {

        // public property, association ("has a") relationship to the 
        // Student class, an array
        public Student[] students;

        
        /// <summary>
        /// Constructor for the class sets class properties
        /// </summary>
        /// <param name="name">the name for this Teacher Person</param>
        public Teacher(string name)
        {
            base.name = name;
            base.birthday(55);
            base.gender = "teacher";
            students = new Student[100];
        }

        /**
         * This method outputs the teacher information (with the inherited talk 
         * method) and then loops through all (active) students and makes them
         * study and talk...
         */
        public void teach()
        {
            base.talk();
            Console.WriteLine("\tHere are my students...");
            // Loop through (traverse) the array...
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    students[i].study();
                    students[i].talk();
                }
            }
        }

    }
}
