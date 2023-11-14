
public class Program
{
    public static void Main(string[] args)
    {
        var task = new TaskLogic();

        Console.WriteLine("WELCOME TO NAVIGATION MENU");
        Console.WriteLine();

        bool choice = true;
        while (choice)
        {
            Console.WriteLine("SELECT EITHER OF THE OPTIONS BELOW TO NAVIGATE THROUGH THE INTERFACES");
            Console.WriteLine() ;
            Console.WriteLine("1) To check the List of States in sets of three");
            Console.WriteLine("2) To Check the Alphabetical Arrangement of states in sets");
            Console.WriteLine("3) To check the Joining of items");
            Console.WriteLine("4) To Exit");
            Console.WriteLine();
            int option = Convert.ToInt32(Console.ReadLine());

 

            switch(option)
            {
                case 1:
                    Console.Clear();
                    task.StateGroup();
                    break;
                case 2:
                    task.ArrangeState();
                    break;
                case 3:
                    task.JoinItem();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default: Console.WriteLine("Please input a Number");
                    break;
            }
        }
    }
}
