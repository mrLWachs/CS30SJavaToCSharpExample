using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** Required package class namespace */
namespace CS30SExample
{

    /// <summary>
    /// Student.cs - represents a student. This class uses inheritance to inherit
    /// the properties and methods from the Person class. This means the Student
    /// class is the child(sub-class) of the parent class Person(super class, 
    /// base class). This is sometimes simplified to a "is a" relationship
    /// </summary>
    class Student : Person
    {

        /**
         * Represents a book object (this object "has a" relationship (association)
         * or "usage" with the student class
         */
        private Book book;
        private int number;
        private double average;


        /// <summary>
        /// Constructor for the class, sets the class properties (including the
        /// properties it inherited form the super or parent class)
        /// </summary>
        /// <param name="name">the name for this student person</param>
        /// <param name="age">the age for this student person</param>
        /// <param name="gender">the gender for this student person</param>
        /// <param name="number">the student number for this student</param>
        public Student(string name, int age, string gender, int number)
        {
            // The keyword "base" is a reference to the "super class" (in this
            // case is "Person) and you can use the keyword to change properties
            // (but not encapsulated/private ones) and call methods
            base.name = name;
            base.gender = gender;
            // To deal with "age" as it is a "private" (encapculated) property
            // we cannot access it directly, but we can through a method...
            base.birthday(age);
            // "this" is an explicit refernce to "this class"
            this.number = number;
            average = 0.0;
            book = new Book();
        }

        /// <summary>
        /// Studying raises the student's average
        /// </summary>
        public void study()
        {
            average += 1.25;
            // or "average = average + 1.25;"
        }

        /// <summary>
        /// Slacking off lowers the student's average
        /// </summary>
        public void slackOff()
        {
            average -= 0.33;
        }

        /// <summary>
        /// Cramming is intense studying
        /// </summary>
        public void cram()
        {
            for (int i = 0; i < 10; i++)
            {
                study();
            }
        }

        /// <summary>
        /// Talking overrides the same talk method of the parent class and outputs
        /// additional information to the screen
        /// </summary>
        public void talk()
        {
            // Even with a class that inherits from another class, we 
            // can call the methods of the parent class
            base.talk();
            Console.WriteLine("\tStudent Number:  " + number);
            Console.WriteLine("\tStudent Average: " + average);
        }

    }
}
