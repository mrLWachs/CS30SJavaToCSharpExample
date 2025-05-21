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
    /// This is a Visual Studio and C# example of the same type of code done in
    /// the Computer Science 30S course for the Graphics and GUIs unit. To build a
    /// Visual Studio project in C#, you should:
    /// 
    /// (1) Open Visual Studio (or you can download it finding links here:
    ///     https://bit.ly/3H3hc65)
    /// (2) Create a new project: a “Windows Forms App (.NET Framework)” C# 
    ///     project…"
    /// (3) Give your project a useful name and put it in a location you are 
    ///     aware of, then click Create…
    /// (4) Now from the main areas of Visual Studio, use the Tool box to 
    ///     start designing by adding (drag and drop, click and drag, or double 
    ///     click the tools) tool objects to your form
    /// (5) Use the properties window to change the properties (liek text, font, 
    ///     etc.) of the various objects (including the form)
    /// (6) Run the program by clicking "Start"
    /// 
    /// You can find more specific tips on getting started and using Visual 
    /// Studio here: https://bit.ly/3YTjnzg
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
            Console.WriteLine("Clicked a button");

            //  This line is a C# verison of "System.out.println()" ...





            ////////////////////////////////////////////////////////////////////////
            // We can see the differences (in some cases the syntax is exactly the
            // same) in the C# language in this IDE vs. the Java language in
            // Netbeans. Here we see the Unit 1 Introdcution content in C# like:
            ////////////////////////////////////////////////////////////////////////

            // Comments.............................................................

            // Are basically the same for inline comments 

            /*
             * Block comments are the same, the only major difference in for 
             * commenting methods and classes, use 3 slashes "///" which will tell
             * Visual Studio how to automate the coding - similar to "/**" in
             * NetBeans
             */

            // Dialogs..............................................................

            MessageBox.Show("This is a message");

            // Variables............................................................
                        
            bool   a = false;    // Unlike Java which uses the entire word "boolean"
            int    b = 0;
            double c = 0.0;
            char   d = 'A';
            string f = "1";         // Unlike Java where "String" uses a capital

            int    g = Convert.ToInt32(f);             // Ways to convert data types
            double h = Convert.ToDouble(f);
            string j = Convert.ToString(b);

            const int CONSTANT = 1;      // Constants use "const" instead of "final"

            // Conditional Statements...............................................

            if (a == true)
            {
                Console.WriteLine(a);
            }
            else if (b >= 0 && c <= 1 && d == 'A' || f != "1")
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

            do
            {
                Console.WriteLine(CONSTANT);
            } while (f != "1");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(e);
            }

            // Methods..............................................................

            int x = actionMethod(a, b);

            // Arrays...............................................................



            ////////////////////////////////////////////////////////////////////////
            // And for a more detailed example of all of our course units (the 
            // introduction unit 1, unit 2 methods, unit 3 arrays, and unit 4
            // classes) - see these links to the same class files as our CS30S
            // example but written in C#:
            //  - ComputerScience30S.cs: https://bit.ly/43rx5L4
            //  - Person.cs: https://bit.ly/45lYNvc
            //  - Student.cs: https://bit.ly/4mqbmMd
            //  - Book.cs: https://bit.ly/44JSb9P
            //  - Husky.cs: https://bit.ly/3ZqFPQg
            //  - Teacher.cs: https://bit.ly/4kd6rNi
            //  - Meeting.cs: https://bit.ly/4jgSBIe
            ////////////////////////////////////////////////////////////////////////

            // ComputerScience30S computerScience30S = new ComputerScience30S();
            // computerScience30S.mainClone();

        }

        /// <summary>
        /// An example of a method written in C# and the IDE Visual Studio also 
        /// will use a lightbulb to help you write methods
        /// </summary>
        /// <param name="a">an example of a parameter</param>
        /// <param name="b">another parameter example</param>
        /// <returns>an example of a return method</returns>
        private int actionMethod(bool a, int b)
        {
            Console.WriteLine(a);
            return b;
        }
    }
}
