using System; //this imports libaries e.g if this was html it would be used to import CSS file

namespace MyFirstConsoleAppDotNet6 //yourname space, to group your classes together
{
    class Program
    {
        static void Main(string[] args) // main method, telling you pc this is where to start, needs to be static
            //void - method to use, you need to specify if the method returns something or not  e.g string or int and so on
            //string[] args - string arry of argumnets, args varible, 

        {
//if statments in C#, when a if statement only has one line you do noit need brackets
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
 //
        }
    }
}