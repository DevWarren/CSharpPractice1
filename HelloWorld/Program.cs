using System;

namespace HelloWorld
{
    //Practice to re familiarise myself with the C# Syntax
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Frank";
            string friend2 = "Joseph";
            string friend3 = "Tim";
            Challenge1();
            Challenge2();
            Challenge3(friend1);
            Challenge3(friend2);
            Challenge3(friend3);

            //Challenge 1
            #region
            static void Challenge1()
            {
                //Declare a string variable and don't assign any value to it.
                string firstString;
                //print on the console "Please enter your name and press enter".
                Console.WriteLine("Please enter your name and press enter: ");
                //Assign that entered string to the variable you declared earlier
                firstString = Console.ReadLine();
                //Output the value in uppercase, lowercase, trimmed and substring.
                Console.WriteLine(firstString.ToUpper());
                Console.WriteLine(firstString.ToLower());
                Console.WriteLine(firstString.Trim());
                Console.WriteLine(firstString.Substring(2));
            }
            #endregion
            //Challenge 2
            #region
            static void Challenge2()
            {
                //Prompt a string from the user
                Console.WriteLine("Enter a quote here: ");
                string secondString = Console.ReadLine();
                //Promt a search of the string from the user
                Console.WriteLine("Enter the character to search: ");
                string searchTerm = Console.ReadLine();
                int searchResult = secondString.IndexOf(searchTerm);
                Console.WriteLine(searchResult);
                //Prompt user for name
                Console.WriteLine("Enter your firstname: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your last name: ");
                string lastName = Console.ReadLine();
                //Dispaly the name
                Console.WriteLine($"Hello {firstName} {lastName}. Your search term starts at index {searchResult}");
            }
            #endregion
            //Challenge 3
            #region
            static void Challenge3(string friendName)
            {
                Console.WriteLine($"Hi {friendName}, my friend");
            }
            #endregion

        }
    }
}
