using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS30SExample
{

    /// <summary>
    /// 
    /// </summary>
    public partial class Form1: Form
    {

        /// <summary>
        /// The class constructor method call an initialize method (similar to how
        /// NetBeans calls the "initComponents" method) from another class - the
        /// "Designer.cs" class file which builds the design, adds all the 
        /// component (tools) objects and sets all the properties
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is written for you ny the Visual Studio designer by double 
        /// clicking the button on the design. Here you can write the action code
        /// for that button
        /// </summary>
        /// <param name="sender">the object sending this action</param>
        /// <param name="e">the event action of that object</param>
        private void button1_Click(object sender, EventArgs e)
        {
            //  This line is a C# verison of "System.out.println()" ...

            Console.WriteLine("Clicked a button");

            ////////////////////////////////////////////////////////////////////////
            // We can see the differences (in some cases the syntax is exactly the
            // same) in the C# language in this IDE vs. the Java language in
            // Netbeans. Here we see the Unit 1 Introdcution content in C# like:
            ////////////////////////////////////////////////////////////////////////

            // Variables............................................................

            int    a = 0;
            bool   b = false;    // Unlike Java which uses the entire word "boolean"
            double c = 0.0;
            char   d = 'A';
            string e = "Hello";         // Unlike Java where "String" uses a capital

            // Conditional Statements...............................................

            if (a == 1)
            {
                Console.WriteLine(a);
            }
            else if (b == true)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }

            // Loops................................................................

            while (c < 10)
            {
                Console.WriteLine(d);
                c++;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(e);
            }

        }
    }
}
