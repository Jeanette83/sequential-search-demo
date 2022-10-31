





namespace sequential_search_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Fred", "Ziggy", "Barny", "Betty", "Wilma", "Bob", "Sally", "Fred", "Dave" };  //if something is not find, we set it to Not found = -1
            string searchName;
            int index;
            ///prompt for the searchName
            Console.WriteLine("Enter a name to search for");
            searchName = Console.ReadLine();
            //find the location of the searchName
            index = SearchArray(names, 8, searchName);
            if (index <= 0)
            {
                //found it!
                Console.WriteLine($"{searchName} was found at {index}");
            }
            else
            { 
                Console.WriteLine($"{searchName} was not founf");
            }
            Console.ReadLine();
        }//end of main

        static int SearchArray(string[] names, int size, string searchName)
        {
            int location = -1;  //this value indicates the search name not found
            for (int index = 0; index < size; index++)
            {
                if (names[index].ToUpper() == searchName.ToUpper())
                { 
                    //found it!
                    location = index;
                    index = size;   ///change the condition of the test! 
                }
            }

            return location;
        }//end of SearchArray



    }
}