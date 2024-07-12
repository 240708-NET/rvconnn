class Program
{
    static void Main( string[] args )
    {

        //Valorant Stats Tracker
        //As a user I want to be able to view all of my agents and see their combined average KDA, W/L and Average combat score
        //I want to view individual agents and view their stats per entry
        //I want to be able to enter "games" where I list agent, map, KDA, W/L and AVG Combat Score

        //Variables


        Console.WriteLine("Welcome to your Valorant Stats Tracker!");
        Console.WriteLine("Choose what you would like to do");
        Console.WriteLine("[1] View all of your Agent's stats");
        Console.WriteLine("[2] View a specific Agent's stats");
        Console.WriteLine("[3] Make a new stat entry");
        Console.WriteLine("[Anything Else] Exit");
        string response = Console.ReadLine();

        switch(response)
        {
            case "1":
                AllAgents();
            break;

            case "2":
                OneAgent();
            break;

            case "3":
                NewEntry();
            break;
            
            default:
            Console.WriteLine("Bye Bye!");
            break;
        }

    } 

    static void AllAgents()
    {
        Console.WriteLine("Show all");
        // Add code for Action 1 here
    }

        static void OneAgent()
    {
        Console.WriteLine("Show one");
        // Add code for Action 1 here
    }

        static void NewEntry()
    {
        Console.WriteLine("New Entry");
        // Add code for Action 1 here
    }

}