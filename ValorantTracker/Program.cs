class Program
{
    static List<Entry> entries = new List<Entry>();
    
    static void Main( string[] args )
    {

        //Valorant Stats Tracker
        //As a user I want to be able to view all of my games and see all of my agents and each of their combined average W/L and Average combat score
        //I want to view individual agents and view their stats per entry
        //I want to be able to enter "games" where I list agent, map, W/L and AVG Combat Score

        Console.WriteLine("Welcome to your Valorant Stats Tracker!");
        Console.WriteLine("Choose what you would like to do");
        Console.WriteLine("[1] View all of your Agent's stats");
        Console.WriteLine("[2] View a specific Agent's stats");
        Console.WriteLine("[3] Make a new stat entry");
        Console.WriteLine("[Anything Else] Exit");
        string response = Console.ReadLine();

        while (response == "1" || response == "2" || response == "3")
        {

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
            }

            Console.WriteLine("Choose what you would like to do");
            Console.WriteLine("[1] View all of your Agent's stats");
            Console.WriteLine("[2] View a specific Agent's stats");
            Console.WriteLine("[3] Make a new stat entry");
            Console.WriteLine("[Anything Else] Exit");
            response = Console.ReadLine();
        } 
        Console.WriteLine("Bye Bye!");
    }

    static void AllAgents()
    {
        Console.WriteLine("Show all");
    }

    static void OneAgent()
    {
        Console.WriteLine("Show one");
    }

    static void NewEntry()
    {
        string response;
        do
        {
            Console.WriteLine("Input Agent Name: ");
            string agent = Console.ReadLine();
            Console.WriteLine("Input Map Name: ");
            string map = Console.ReadLine();
            Console.WriteLine("Input your Average Combat Score: ");
            int avgcs = int.Parse(Console.ReadLine());
            Console.WriteLine("Input [W] if you Won or [L] Lost the game: ");
            string wl = (Console.ReadLine());

            Entry newEntry = new Entry(agent, map, avgcs, wl);
            entries.Add(newEntry);

            Console.WriteLine("New entry added successfully!");

            Console.Write("Do you want to make another entry? [Y or N]: ");
            response = Console.ReadLine();
        } while(response.ToUpper() == "Y");
        

    }

}