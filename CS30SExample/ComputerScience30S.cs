
/**
 * Required imports ("using") for the project - the lines below are 
 * added when your code needs to connect to another library (API) of code
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Required class namespace - the line below is put in automatically,
 * and connects this file to the project
 */
namespace CS30SExample
{
    /// <summary>
    /// ComputerScience30S.cs - the large in class example we continue to work on
    /// in each unit adding example code on the new concepts of each unit along with
    /// any in class requests for code example that might come up over the course.
    /// </summary>
    class ComputerScience30S
    {

        /// <summary>
        /// A "clone" of a main method for this project
        /// </summary>
        public void mainClone()
        {
            learnIntroToJava();  

            // "Call" a method (means you use the name of the method)
            learnMethods();
            learnArrays();
            learnClasses();
        }

        /// <summary>
        /// Learn the content of the introduction unit (unit 1)
        /// </summary>
        private void learnIntroToJava()
        {
            ///////////////////////////////////////////////////////////////////////
            // JAVA BASIC INPUT AND OUTPUTS
            ///////////////////////////////////////////////////////////////////////


            // This is a comment!

            // All typing after "//" until the line ends is called a comment        
            // Commments are not code, so you can write what you want        
            // Curly brackets (braces, parenthesis) { and } are important        
            // All code right now goes between these two brackets. Comments are 
            // not code, so you can write what you want

            // Clicking the green triangle on the toolbar above will "run" or
            // "compile" your code and show you the running program in an output
            // window below...        

            /*  
                This is for multiple line comments, as it covers as many lines as
                you want starting with "slash star" until it sees the closing 
                "star slash"
            */

            // A basic output
            Console.WriteLine("Hello World"); // Comments can be on code lines

            Console.WriteLine(" I'm in ");
            // Spaces, you have to add them inside the quotes

            Console.WriteLine("The world!");

            // There are "shortcuts" to coding (see the tips below)  
            Console.WriteLine("Good-bye World");

            // Additional output tips... (these are "special" characters)

            Console.WriteLine("Make a quote \" ");         //  \" Makes quote
            Console.WriteLine("Make a slash \\ ");         //  \\ Makes slash
            Console.WriteLine("Make a \t tab ");           //  \t Make "tab" 
            Console.WriteLine("Make a \n new line break"); // \n Makes break

            // In all these, the key is to use the "\" backslash
            // which is called an "escape character"

            // Dialog types of input and outputs, and are little tiny "windows", 
            // "forms", "graphical rectangles" and are somewhat "fancier" ways to
            // do an input/output with a dialog box (in C# it was "Message box")

            MessageBox.Show("Hello World");

            // Above line of code is the ONLY one needed for assignment, final 
            // project, etc.

            // For inputs (meaning the user is involved in giving us data)...
            // An "input" dialog box - C# does NOT have an inputbox
            // equivilent to Java's:
            // JOptionPane.showInputDialog("Enter something");

            // However.............................................................

            // Optionally (not required) now some examples of other things you can
            // do with these message/input dialog boxes...

            // Code could span multiple lines until it reaches a semi colon ";"
            // The light red line on the far right -------------------------------->
            // can be thought of as a "barrier" and you should try not to code too
            // much past this line

            MessageBox.Show("Message 2", "Title 2");

            MessageBox.Show("Message 3",
                            "Title 3",
                            MessageBoxButtons.YesNo);

            MessageBox.Show("Message 4",
                            "Title 4",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

            MessageBox.Show("Message 5",
                            "Title 5",
                            MessageBoxButtons.RetryCancel,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button2);

            MessageBox.Show("Message 6",
                            "Title 6",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign,
                            true);

            ///////////////////////////////////////////////////////////////////////
            // VARIABLES:
            ///////////////////////////////////////////////////////////////////////

            // A variable is a piece of code that tells the computer to
            // store (or "remember") information (or "data")

            // This is an example of the simpliest variable type:

            bool a = true;

            // type name = value ;

            int b = 0;

            // When you write a line of code to create (declare) a variable

            double c = 0.0;

            // Variables can change ("vary")
            a = false;
            b = 1;
            c = 1.2;

            // Variables always go on the left hand side (LHS) of the equals
            // sign (=) and the value going into the variable always goes on
            // the right hand side (RHS)

            // Output our variables when outputted it always outputs the 
            // value stored in the variable not the name of it

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);

            // The "char" is short for "character" it holds (remembers) ONE
            // character

            char d = 'A';

            Console.WriteLine("d = " + d);

            // The boolean ("bool" in C#), integer (int), double, and character
            // (char) are all simple (primitive) data types, now a "complex" data
            // type....

            string e = "apple";

            Console.WriteLine("e = " + e);

            // Manipulate ("use") our variables...

            int x = 0;

            Console.WriteLine("x = " + x);

            x = 20;

            Console.WriteLine("x = " + x);

            int y = x + 10;

            Console.WriteLine("y = " + y);

            // Optional ("you don't have to use this code") shorthand...

            y++;    // Means the same as y = y + 1;
            y--;    // Means the same as y = y - 1;

            // Even more shorthand (less recommended)

            y += 10;    // Means the same as y = y + 10;
            y -= 10;    // Means the same as y = y - 10;
            y *= 10;    // Means the same as y = y * 10;
            y /= 10;    // Means the same as y = y / 10;

            Console.WriteLine("y = " + y);

            // Modulus (mod) division gives you the remainder of a division
            // (not the normal answer) - in Java it uses the percentage "%"
            // symbol for this

            x = 28;
            y = x / 5;

            int z = x % 5;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);

            // Constants are variables that don't change (they stay "constant"),
            // and constants are written in ALL_CAPITAL_LETTERS with underscores
            // to seperate words

            const double PI = 3.141592653589793;
            const int PROBLEMS = 99;
            const char YES = 'Y';
            const bool FOUND = true;
            const string  COMPUTER_TEACHER = "Wachs";

            Console.WriteLine(PI + "," +
                              PROBLEMS + "," +
                              YES + "," +
                              FOUND + "," +
                              COMPUTER_TEACHER);

            // In a line of code, one space or multiple spaces doesn't matter
            // as seen above when declaring constants (it only matter when
            // between quotation marks). You can hit enter in a line of code
            // to break to a new line, because the computer will still consider
            // it ONE line of code until we reach the semicolon.

            // Constants are used for things like: easier code to maintain,
            // easier to read/understand (especially for other programmers)

            // Converting between variable data types...

            int f = 25;

            Console.WriteLine("f = " + f);

            double g = f;

            Console.WriteLine("g = " + g);

            g = 25.9999999999999;

            Console.WriteLine("g = " + g);

            int h = (int)g;

            Console.WriteLine("h = " + h);

            // When we use round brackets ( )  with a data type inside, this is
            // called "casting" which means it converts (temporarily) to another
            // data type - which meant it ignored the decimal part

            double k = 2.9999999999;
            int l = (int)k;
            double m = (double)l;

            // Casting can also happen with other data types...

            char n = 'A';
            int o = (int)n;
            char p = (char)70;

            Console.WriteLine("k = " + k);
            Console.WriteLine("l = " + l);
            Console.WriteLine("m = " + m);
            Console.WriteLine("n = " + n);
            Console.WriteLine("o = " + o);
            Console.WriteLine("p = " + p);
                        
            // The variable (always has to start as a string) stores what the 
            // user types in the input dialog box

            // With numbers, you HAVE to start off with a string, and then convert
            // it to a number. 

            string r = "1";
            int s = Convert.ToInt32(r);
            MessageBox.Show("int is " + s);

            // Same type of example but with a double...

            string t = "1.2";
            double u = Convert.ToDouble(t);
            MessageBox.Show("double is " + u);

            // Example with a char (single character)...

            string v = "a";
            char w = v[0];
            MessageBox.Show("char is " + w);

            // Strings have MANY built-in "actions" (function, methods)

            String word = "hippopotomonsprosesquippedaiophobia";
            int length = word.Length;

            Console.WriteLine("word " + word + " is length " + length);

            String upper = word.ToUpper();

            Console.WriteLine("word " + word + " in upper case is " + upper);

            // Many more string functions can be explored

            // "Math" library of code is also "built-in" to java
            // which comes with it's own functions (actions, methods)

            double answer1 = Math.PI;
            double answer2 = Math.Cos(0.5);
            double answer3 = Math.Abs(-1);
            double answer4 = Math.Pow(5, 3);
            double answer5 = Math.Sqrt(9);
            double answer6 = Math.Log(0.5);

            Console.WriteLine("answer1 = " + answer1);
            Console.WriteLine("answer2 = " + answer2);
            Console.WriteLine("answer3 = " + answer3);
            Console.WriteLine("answer4 = " + answer4);
            Console.WriteLine("answer5 = " + answer5);
            Console.WriteLine("answer6 = " + answer6);

            // Math library also does random numbers...

            Random random = new Random();

            double seed = random.NextDouble();

            // The "seed" generates a number (decimal) between
            // 0 and 1 (but it never reaches 0 or 1)

            Console.WriteLine("seed = " + seed);

            // You can use a formula for generating random numbers in a range
            // between a low and a high number

            // e.g. between 1 and 10 and make it an integer

            // Start with some constants defining the low and high

            const double LOW = 1.0;
            const double HIGH = 10.0;

            // Now the formula to generate in that range

            double number = (HIGH - LOW + 1) * seed + LOW;

            Console.WriteLine("number = " + number);

            // Now cast it into an int

            int value = (int)number;

            // and display it

            Console.WriteLine("value = " + value);

            // Do it again, but simplify the formula (between 2-53)

            int card = (int)((53 - 2 + 1) * random.NextDouble() + 2);
            Console.WriteLine("card = " + card);

            ///////////////////////////////////////////////////////////////////////
            // CONDITIONAL STATEMENTS
            ///////////////////////////////////////////////////////////////////////

            // The simple if statement, you use this when comparing if something is
            // true, as it checks that one thing ("asks a true/false question")

            // If statements use both ( ) round and { } curly brackets and the 
            // code inside of the curly brackets is said to be in a "block" of
            // code and that block only runs when the test inside of the round
            // brackets tests TRUE. It also indents the code inside the block

            int value1 = 10;
            int value2 = 10;

            if (value1 == value2)
            {
                Console.WriteLine("equal");
            }

            if (value1 < value2)
            {
                Console.WriteLine("They are ");
                Console.WriteLine("less than");
            }

            // All lines of code between the curley brackets { } is in a block that 
            // is "controlled" by the conditional (if) statement

            // if with "else" (an option) for both true and false, check 2 things

            double value3 = 1.45, value4 = 1.5;

            // Using a comma is a option (I do not recommend)

            if (value3 < value4)
            {
                Console.WriteLine("less than");
            }
            else
            {
                Console.WriteLine("greater than");
            }

            // Use chars and some shorthand, not usually recommended (except in 
            // certain situations) used when the code in a block - between { } is
            // only one line of code! Then, you don't need the { } 
            // And.. (even further shorthand) the line can be moved up to the
            // same line as the if statement

            char value5 = 'A';
            char value6 = 'a';

            if (value5 != value6) Console.WriteLine("!=");
            else                  Console.WriteLine("==");

            // Use "else if" for multiple cases of more than 2 things (same as the
            // "switch" statement - which I don't use) use strings for this
            // example which are more complex (because they use many character,
            // and upper and lower case)

            // NOTE: with string NEVER use == ALWAYS use .equals()...

            string word1 = "edgy";
            string word2 = "eDgy";

            if (word1 == word2)
            {
                Console.WriteLine("equal");
            }
            else if (word1 == word2)
            {
                Console.WriteLine("kind of equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }

            // Combine logic using "and" "or" "not" which use the symbols:
            // "&&" for "and"
            // "||" for "or"
            // "!"  for "not"

            int age = 17;
            double iq = 100.0;

            if (age >= 21 && iq > 130)
            {
                // with "AND" (&&) BOTH have to be true
                Console.WriteLine("Get in!");
            }
            else if (age >= 18 || iq >= 100)
            {
                // with "OR" (||) EITHER can be true
                Console.WriteLine("Keep trying...");
            }
            else
            {
                Console.WriteLine("Get out!");
            }

            ///////////////////////////////////////////////////////////////////////
            // LOOPING
            ///////////////////////////////////////////////////////////////////////

            // Simple loop...

            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine("counter = " + counter);
                counter++;  // counter = counter + 1;
            }

            // while Loop with a string

            String password = "1234";

            while (password == "1234")
            {
                MessageBox.Show("Try again!");
                password = "123";
            }

            // The next type of loop is rarely used (you may never need it)
            // it tests for true/false at the bottom of the loop, you use it
            // when you want the body (block) of the loop to run at least
            // once!

            String choice = "";

            do
            {
                choice = "123";
            } while (choice != "123");

            MessageBox.Show("Correct!");

            // The "for" loop is used for counting (and for the upcoming unit 
            // called "arrays"). It is a much more technical ("codey") looking loop
            // The inside of the round brackets means: ( start ; end ; change)        
            // The for loop creates its own variable (by default NetBeans calls
            // it "i") - short for "iteration"

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Variations on the for loop:
            // start at 100
            // end (stop) at zero (including zero)
            // count down (not up)
            // count by 10s

            for (int i = 100; i >= 0; i = i - 10)
            {
                Console.WriteLine("i = " + i);
            }

            for (int counting = 100; counting <= 500; counting *= 2)
            {
                Console.WriteLine("counting = " + counting);
            }

            // This line terminates any running program at any point
            // Application.Exit();

            // Curly brackets (braces, parenthesis) { and } are important - all 
            // code goes between these two brackets  
        }

        /// <summary>
        /// Learn the content of the methods unit (unit 2)
        /// </summary>
        private void learnMethods()
        {
            Console.WriteLine("Start learning methods...");

            // Methods (functions, procedures, actions) are named in a style like 
            // variables are named (lowercase then camel casing), but use verb
            // type words starting with lowercase then using camel casing the
            // presense of round brackets ( ) indicate a method. We make methods
            // for: (1) to break up a problem (2) reusability (3) to avoid 
            // repeating code

            // Code to "jump" to a method, is "calling" the method (method call) 
            writeStar();

            // Call it again
            writeStar();

            // When we call a method, we sometimes place "data" (information) 
            // inside the round brackets and that data is "passed" (sending) over 
            // to the method. The data being passed is technically called the
            // "argument" and the data being recieved is called the "parameter(s)". 
            // You can always change the arguement.

            write("something");

            write("Spider-man");

            write("Batman");
            write("Superman");
            write("Omni-man");
            write("Mr. Wachs");

            // You can have more than one, multiple parameters/arguments in a 
            // method which are seperated with commas ","

            writeLotsOf("Dalmations", 101);

            writeLotsOf("Problems", 99);

            // You can make methods that "send back" (output) information, the 
            // previous methods needed information (inputs) as parameters or 
            // empty brackets () if they did not need information passed

            int number = giveMeNumber();

            write("Number was " + number);

            output("Hello");

            output("Good-bye", "Learning");

            // Overloaded methods are methods with the same name, BUT different
            // parameters / arguments

            Console.WriteLine("Completed learning methods!");
        }

        /// <summary>
        /// Writes a star on the screen
        /// </summary>
        private void writeStar() 
        {
            Console.WriteLine("*");
        }

        /// <summary>
        /// Writes something on the screen
        /// </summary>
        /// <param name="thing">thing the something to write (input)</param>
        private void write(String thing)
        {
            // The parameter (called "thing") is the term when you write the
            // method, and when you call the method it is called the arguement
            Console.WriteLine(thing);
        }

        /// <summary>
        /// Writes something on the screen multiple times
        /// </summary>
        /// <param name="thing">the something to write</param>
        /// <param name="times">how many times to write it </param>
        private void writeLotsOf(String thing, int times)
        {
            // Methods can have no parameters, one parameter, or lots of parameters,
            // if it has more than one parameter, they are separated by commas
            for (int i = 0; i < times; i++)
            {
                write(thing);
            }
        }

        /// <summary>
        /// Gives you a random number
        /// </summary>
        /// <returns>random number between 1 and 10 (output)</returns>
        private int giveMeNumber()
        {
            // Methods can have no outputs (the word "void") or can have ONE output
            // which means the method will "return" that data type in the method
            return random(1, 10);
        }

        /// <summary>
        /// Generates a random number in a range between two numbers
        /// </summary>
        /// <param name="low">the lowest number in the range</param>
        /// <param name="high">the highest number in the range</param>
        /// <returns>random number less than or equal to low and greater than or 
        /// equal to high</returns>
        private int random(int low, int high)
        {
            Random random = new Random();
            double seed = random.NextDouble();
            double L = (double)low;
            double H = (double)high;
            double number = (H - L + 1) * seed + L;
            return (int)number;

            // Note: the code could also be written other ways like...
            //return (int)(( high - low + 1) * random.NextDouble() + low);        
        }

        /// <summary>
        /// Display text in a dialog box
        /// </summary>
        /// <param name="text">the text to display</param>
        private void output(String text)
        {
            MessageBox.Show(text);
        }

        /// <summary>
        /// Display text in a dialog with a title at the top of the dialog
        /// </summary>
        /// <param name="text">the text to display</param>
        /// <param name="title">what to show at the top of the dialog</param>
        private void output(String text, String title)
        {
            // Overloaded methods are methods with the same name, BUT different
            // parameters / arguments so we know which version of the method to call
            MessageBox.Show(text, title);
        }

        /// <summary>
        /// Learn the content of the arrays unit (unit 3)
        /// </summary>
        private void learnArrays()
        {
            Console.WriteLine("Start Learning Arrays...");

            // Create (declare) a simple variable (for comparison)
            int variable = 5;
            Console.WriteLine(variable);

            // E.g. in memory a variable could "look" like...
            //
            //          +-------+
            // variable |   5   | (type integer)
            //          +-------+

            int[] array = new int[5];

            // The order of words in declaring an array:
            // (1)    (2)    (3)   (4)   (5)     (6)    (7)                     (8)
            // type   [ ]    name   =    "new"   type    [ size of the array ]   ;

            // E.g. in memory an array could "look" like...
            //
            //       +-------+-------+-------+-------+-------+
            // array |       |       |       |       |       | (a length of 5)
            //       +-------+-------+-------+-------+-------+

            // Array names are usually "plural" words
            // The square brackets "[  ]" in code indicate we are using an array, 
            // the word "new" is used because arrays (they are technically 
            // "advanced" data types) are more complicated than variables (which 
            // are "simple" or "primitive" data types) then you repeat the data 
            // type ("int" in this case) and the square brackets are also repeated 
            // with a number (or a variable) inside - this number represents the 
            // SIZE of the array. When arrays are first created, they are EMPTY.

            // The array has now 5 "spots" (or "index", "elements", "subscript")
            // which automatically numbers them - BUT the first spot is ALWAYS
            // numbered as spot zero and the rest and numbered in order:
            //
            //       +-------+-------+-------+-------+-------+
            // array |       |       |       |       |       | (indexed)
            //       +-------+-------+-------+-------+-------+
            //           0       1       2       3       4

            array[0] = 25;
            array[1] = 250;
            array[2] = 2;
            array[3] = 0;
            array[4] = -25;

            //       +-------+-------+-------+-------+-------+
            // array |   25  |  250  |   2   |   0   |  -25  | (now filled)
            //       +-------+-------+-------+-------+-------+
            //           0       1       2       3       4

            // These next lines would be errors when the code runs:
            // array[5] = 25;
            // array[500] = 25;        
            // array[-1] = 25;
            // The above lines would all be "out of bounds" errors (or "range" error)

            // array[2.5] = 25; 
            // The above line is an example of a "syntax" error (usually caught by 
            // the IDE in this case NetBeans)

            // Declare an array (a little differently) of NO size...
            double[] a;

            // In memory...
            //
            // a
            //

            // Later on (in the code) you can re-create (re-declare, re-dimension, 
            // or resize) using the same array but now giving it some size (but 
            // still empty)

            a = new double[3];

            // In memory....
            //
            //   +----------+----------+----------+
            // a |          |          |          | (now has size of 3, but empty)
            //   +----------+----------+----------+
            //        0          1          2

            // Now fill the content
            a[0] = 1.1;
            a[1] = 2.2;
            a[2] = 3.3;

            //   +----------+----------+----------+
            // a |   1.1    |   2.2    |   3.3    | (now it is filled with content)
            //   +----------+----------+----------+
            //        0          1          2

            // You can re-dimension (resize) an array multiple times, BUT
            // every time it wipes out any content stored in the array

            a = new double[5];

            //   +----------+----------+----------+----------+----------+
            // a |          |          |          |          |          | (size 5)
            //   +----------+----------+----------+----------+----------+
            //        0          1          2          3          4

            // Another way to declare arrays, but this way creates the array of
            // a set size, BUT with pre-filled values inside (make and fill at the
            // same time - on the same ONE line of code) - you can as an option,
            // put the "[]" beside the data type OR the array name

            double[] coins = { 0.05, 0.10, 0.25, 1.00, 2.00 };

            //       +------+------+------+------+------+
            // coins | 0.05 | 0.10 | 0.25 | 1.00 | 2.00 |  (has a length of 5)
            //       +------+------+------+------+------+
            //          0      1      2      3      4  

            // You can also create CONSTANT arrays that are pre-filled, the name
            // we gives array should be a plural word (e.g. 'scores' (array name)
            // not 'score' (variable name), 'names' not 'name', etc.) 

            string[] OPTIONS = {
                "New Game",
                "Save Game",
                "Quit"
            };

            // When using arrays, use individual elements (spots, indices - the 
            // plural of "index") of the array like regular variables, for example

            int[] numbers = new int[100];

            // Change (or "assign") a index (spot)
            numbers[99] = 333;

            //         +-----+-----+-----+
            // numbers |     | ... | 333 | (length is 100)
            //         +-----+-----+-----+
            //            0    ...   99
            // Remember, the last index is always ONE LESS than the length

            numbers[0] = numbers[99] * 2;
            Console.WriteLine(numbers[0]);

            //         +-----+-----+-----+
            // numbers | 666 | .?. | 333 | 
            //         +-----+-----+-----+
            //            0    ...   99

            // To work with, and to "travel" (means to "visit" every spot) the 
            // entire array, we use a loop!

            // Specifically, the FOR loop!

            // for loops were literally built for arrays
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + " = " + numbers[i]);
            }
            // The for loop is perfect because it automatically (when I type "for"
            // and TAB) starts at 0, goes up by 1, is "less than" then ending 
            // number (which can be the length)

            // When using the for loop with arrays, it is even BETTER to use a
            // built-in feature of all arrays! All arrays have a ".length" feature
            // for example
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i + " = " + numbers[i] + " again!");
            }

            // Tip: if type "for" TAB, then TAB AGAIN it jump to the ending value
            // So if the array size changes, the loop adapts to it

            // Arrays can easily work with methods, the arrays can be sent into a 
            // method (as one of multiple parameters, or the only parameter), and 
            // arrays can be outputted (returned) from a method - in other words:
            // Arrays can be INPUT(s) or OUTPUT from a method

            output(array);      // Send a array to a method as a parameter
            output(numbers);    // Call the method with a different argument
            output(coins);      // Overload the "output" method again

            // Test again...
            double[] examples = { 3.14, 0.01, 99.99, 9876.54321 };
            output(examples);

            int[] randoms = random(1, 10, 50);    // Overload "random" method
            output(randoms);

            // Multi-dimensional array (also known as a "array of arrays", or a 
            // array filled with other arrays, 2D, etc.) - and also known as a 
            // table, grid, or a MATRIX

            // We declare (create) a matrix , by adding multiple sets of square
            // brackets (a set of brackets for each dimension)

            char[,] twoDArray = new char[1, 2];
            twoDArray[0, 0] = 'A';
            twoDArray[0, 1] = 'B';

            // Advice, when working with matrices, I recommend using variable and 
            // constants with names the make sense (to you!)

            // Create some constants to use when building the matrix (these are
            // not needed to declare a matrix, but they might help in understanding 
            // it) - we make contants as a way to "visualize" what we are building

            const int ROWS = 30; // "dimension" going "down" (also like "y" axis)
            const int COLUMNS = 40; // "dimension" going "across" (also like "x")

            char[,] matrix = new char[ROWS, COLUMNS];

            // If we "visualize this as a 3 by 4 matrix (3 rows by 4 columns), or 
            // y = 3 and x = 4, or a "height" of 3 and a "width" of 4, then it
            // could be "seen" as...
            //
            //               (columns, width, x axis is 4, meaning 0-3)
            //
            //                     0         1         2         3
            //                +---------+---------+---------+---------+
            // (rows,       0 |         |         |         |         |
            //  height,       +---------+---------+---------+---------+
            //  y axis      1 |         |         |         |         |
            //  is 3,         +---------+---------+---------+---------+
            //  meaning     2 |         |         |         |         |
            //  0-2)          +---------+---------+---------+---------+
            // 
            // A matrix "row" can also be "visualized" as the matrix "height"
            // A matrix "column" can also be "visualized" as the matrix "width"

            // Fill the matrix with random characters...        

            // Test our random character method first...

            char character = random('A', 'Z');
            Console.WriteLine("Random character was " + character);

            // Fill our matrix (meaning put content in every location/index/spot
            // in the matrix) by traversing (travelling, 'visit' every spot) the
            // matrix and adding random characters (our method) - when traversing
            // matricies (plural of matrix) we use multiple nested for loops

            // We might rename looping variables to better understand what the 
            // nested for loops are refering to (e.g. like row, column, x, y)
            // With Netbeans, when you rename a loop variable it renames all 3

            // Create some constants for the characters
            const char LOW = '!';
            const char HIGH = '~';

            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLUMNS; column++)
                {
                    matrix[row, column] = random(LOW, HIGH);
                }
            }

            // Output the matrix, using a method which turns the entire matrix into
            // a string (which we can then output with one of our existing methods)

            string text1 = toString(twoDArray);
            output(text1);
            string text2 = toString(matrix);
            output(text2);

            Console.WriteLine("Completed learning Arrays!");
        }

        /// <summary>
        /// Output an array of integers in a dialog
        /// </summary>
        /// <param name="array">the array of integers</param>
        private void output(int[] array)
        {
            // Arrays can be a parameter (or one of the parameters)
            string text = "Array = [";
            // Loop (traverse) through the array and add the contents (what is 
            // stored at each index) to the string
            for (int i = 0; i < array.Length; i++)
            {
                text += array[i] + ",";
            }
            text += "]";    // "+=" means the same as "text = text + ..." 
            output(text);
        }

        /// <summary>
        /// Convert all the double into integers and then output the array
        /// </summary>
        /// <param name="array">the array of double</param>
        private void output(double[] array)
        {
            int[] a = convert(array);
            output(a);
        }

        /// <summary>
        /// Converts an array of double into an array of integers
        /// </summary>
        /// <param name="array">the array of doubles</param>
        /// <returns>an array of integers</returns>
        private int[] convert(double[] array)
        {
            // Methods can return (output) entire arrays
            int[] a = new int[array.Length];      // Create empty array (same size)
                                                  // Copying over all the content from the double array to the int array
            for (int i = 0; i < a.Length; i++)
            {  // Traverse the array
                a[i] = (int)array[i];             // Cast the double into a int
            }
            return a;                             // Return the converted new array 
        }

        /// <summary>
        /// Generates an array of a set size filled with random integers in the 
        /// range between low and high
        /// </summary>
        /// <param name="low">the lowest number in the range</param>
        /// <param name="high">the highest number in the range</param>
        /// <param name="size">the size to make the array</param>
        /// <returns>an array of random integers</returns>
        private int[] random(int low, int high, int size)
        {
            int[] numbers = new int[size];      // Create empty array of passed size
            for (int i = 0; i < size; i++)
            {    // Traverse array 
                numbers[i] = random(low, high); // Assign random value to each index
            }
            return numbers;                     // Return completed array
        }

        /// <summary>
        /// Generates a random character between tow low and high characters
        /// </summary>
        /// <param name="low">lowest character in the range</param>
        /// <param name="high">highest character in the range</param>
        /// <returns>random character in range</returns>
        private char random(char low, char high)
        {
            return (char)random((int)low, (int)high);     // cast to int and back  
        }

        /// <summary>
        /// Change the matrix into a single string (for outputting)
        /// </summary>
        /// <param name="matrix">the 2D array of characters</param>
        /// <returns>a single string representing the matrix</returns>
        private string toString(char[,] matrix)
        {
            String text = "";   // Create string variable to store all values
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    // Means the length of "this row"  
                    text = text + matrix[r,c] + " ";
                }
                text = text + "\n";     // Add a line break after each row
            }
            return text;            // Return the filled up string
        }

        /// <summary>
        /// Learn the content of the classes unit (unit 4)
        /// </summary>
        private static void learnClasses()
        {
            Console.WriteLine("Start learning classes...");

            // Create a "person" (add a class called "Person" to this Java project)
            // To do this, you can: see tip #27 in the "NetBeans Tips" comments
            // section at the bottom of this code...

            // Note: when in the past we used a line of code like this:
            // Random random = new Random();
            // It related directly to what we are doing in this unit...

            Person person = new Person();

            // Class object = new Class() <--- implies a method?
            // that is the call to the constructor method

            // person.born();
            // The original "born" method was changed into a constructor

            // We can call (invoke) methods within the object
            person.talk();
            person.name = "John Doe";

            // Note: the "age" property was originally public but then it was
            // "encapsulated" by making it a "private" so it can no longer be 
            // accessed (read) or modified (changed) outside the class

            // person.age  = 35;

            person.gender = "non-binary";

            // Note: this method was originally public but then it was
            // "encapsulated" by making it a private (helper) method so it can 
            // no longer be called (invoked) outside the class

            // person.birthday();

            // I now can call a version of the birthday() (over-loaded) method
            // that we added later...

            person.birthday(36);

            person.talk();
            person.die();
            person.talk();

            // Create (instantiate) another object with a different (overloaded) 
            // constructor 
            Person other = new Person("Another name");
            other.talk();

            // Another instance using the 3rd constructor option
            Person third = new Person("Three Thurdy", 33, "fluid");
            third.talk();

            // Create a Student object and call it's methods (including the 
            // ones it inherited from the Person class)   
            Student student = new Student("Robert Studentson", 17, "stew", 123);
            student.talk();
            // Call (invoke) methods specifically for the student class   
            student.study();
            student.talk();
            student.slackOff();
            student.talk();
            student.cram();
            student.talk();
            // Still can call inherited methods
            student.die();
            student.talk();

            // Instantiate a Husky object
            Husky husky = new Husky("Havoc", 18, "Dog", 2665);
            husky.talk();

            // Make a Teacher instance (an object)
            Teacher teacher = new Teacher("Mr. Wachs");

            // Assign student objects to this teacher 
            // "give the teacher some students"        
            teacher.students[0] = student;
            teacher.students[1] = husky;

            // Now call the method...
            teacher.teach();

            // Build (declare, initiaize, instantiate) a Meeting object
            Meeting meeting = new Meeting();

            // Calling our polymorphic method
            meeting.attend(person);
            meeting.attend(other);
            meeting.attend(third);
            meeting.attend(student);
            meeting.attend(husky);
            meeting.attend(teacher);

            meeting.hold();

            Console.WriteLine("Completed learning classes!");
        }

    }
}
