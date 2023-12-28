using System; //this imports libaries e.g if this was html it would be used to import CSS file

namespace MyFirstConsoleAppDotNet6 //yourname space, to group your classes together
{
    class Program
    {
        static void Main(string[] args) // main method, telling you pc this is where to start, needs to be static
            //void - method to use, you need to specify if the method returns something or not  e.g string or int and so on
            //string[] args - string arry of argumnets, args varible, 

        {
            /////////////////////////////////////////////////////////////////////////////
            /////////////////////////////if statments in C#//////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////
            //when a if statement only has one line you do noit need brackets
            Console.WriteLine("IF STATEMENTS");
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
            Console.WriteLine();
            /////////////////////////////////////////////////////////////////
            /////////////////////////////Loops//////////////////////////////
            ///////////////////////////////////////////////////////////////
            Console.WriteLine("LOOPS");
            ///While and Do statements
            int counter = 0;
            do//The do ... while loop executes the code first, and then checks the condition
            {
                Console.WriteLine($"The while counter is {counter}");
                counter++; // ++ after the counter variable is the increment operator, it adds 1.
            }
            while (counter < 10);// if you say (true) it would create an infinite loop, press crtl + C to stop 
            //The while loop tests the condition before executing the code following the while
            Console.WriteLine();
            ///For statement
            //for loop has three parts that control how it works.
            for (int counter1 = 0; //for initializer declares that counter is the loop variable, and sets its initial value to 0.
                counter1 < 10; //for condition declares that this for loop continues to execute as long as the value of counter is less than 10.
                counter1++) //for iterator specifies how to modify the loop variable after executing the block (e.g to add 1).
            {
                Console.WriteLine($"The for loop counter is {counter1}");
            }
            //for (int i = 0; i < length; i++) for snippet tab twice to get
            //{

            //}
            ////////////////nested loops//////////////////////////
            ///while, do, or for loop can be nested inside another
            ///One for loop can generate the rows:

            //for (int row = 1; row < 11; row++)
            //            {
            //                Console.WriteLine($"The row is {row}");
            //            }

            //            Another loop can generate the columns:


            //for (char column = 'a'; column < 'k'; column++)
            //            {
            //                Console.WriteLine($"The column is {column}");
            //            }

            //            You can nest one loop inside the other to form pairs:


            //for (int row = 1; row < 11; row++)
            //            {
            //                for (char column = 'a'; column < 'k'; column++)
            //                {
            //                    Console.WriteLine($"The cell is ({row}, {column})");
            //                }
            //            }

            ///////Combine branches and loops
            //find the sum of all integers 1 through 20 that are divisible by 3. 
            Console.WriteLine();
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine();
            /////////////////////////////////////////////////////////////////////
            //////////Arrays, List, and Collections//////////////////////////////
            ////////////////////////////////////////////////////////////////////
            Console.WriteLine("Arrays, List, and Collections");
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            ///The foreach statement repeats its statement for every item in a sequence of items. It's most often used with collections
            foreach (var name in names) ///foreach  statement
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            //Modify list contents
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine();
            //The List<T> enables you to reference individual items by index as well.
            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            //You can check how long the list is using the Count property. 
            Console.WriteLine($"The list has {names.Count} people in it");
            Console.WriteLine();
            Console.WriteLine("Search and sort lists");
            //////Search and sort lists
            //The IndexOf method searches for an item and returns the index of the item. If the item isn't in the list, IndexOf returns -1.
            var index = names.IndexOf("Felipe");
            if (index != -1)
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }
            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
            Console.WriteLine();
            //sort alphabetically for strings
            Console.WriteLine("sort");
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            //Lists of other types e.g Fibonacci Sequence
            Console.WriteLine();
            Console.WriteLine("Fibonacci Sequence");
            var fibonacciNumbers = new List<int> { 1, 1 }; //That creates a list of integers, and sets the first two integers to the value 1
            //Each next Fibonacci number is found by taking the sum of the previous two numbers
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
   
}
//End of C# Turotial documentation https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/list-collection?tutorial-step=7