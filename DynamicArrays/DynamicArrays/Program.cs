using DynamicArrays;

class Program
{
    public static void Main(string[] args )
    {
        DynamicArray da = new DynamicArray(3);

        bool WantToContinue = true;
        string input = "";
        int number = 0;

        while (WantToContinue)
        {
            Console.WriteLine("Do you wish to continue?? Y or N ");
            input = Console.ReadLine();

            if (input == "Y" || input == "y")
            {
                Console.WriteLine("Enter a number to enter in the array: ");
                number = int.Parse(Console.ReadLine());
                da.PushBack(number);
            }
            else
                WantToContinue = false;
        }
        Console.ReadKey();
    }
}