class Program
{

    static List<string> CreatedLunches = new List<string>();
    
    static void Main( string[] args )
    {
        
        //I want to create a console app that creates lunches for the user
        //option 1 will allow the user to view all past created meals(data persistance)
        //option 2 will allow the user to choose between three different entree items: Salad, Sandwich, Ramen
        //After selecting an entree it will take the user through different aspects of the item, e.g. for sandwich: bread, main item, cheese
        //the user will first see all of the bread options and enter for the app to randomly choose one of the options
        //after going through each option, the app will list the choices for the completed item and will cycle back to the option menu

        Console.WriteLine("Welcome to Roll For Lunch!");
        Console.WriteLine("Let RNG decide your next lunchtime meal");
        
        bool running = true;    
        while (running)
        {    
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("[1] View all created meals");
            Console.WriteLine("[2] Create a new Lunch");
            Console.WriteLine("[3] Exit");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ViewCreatedLunches();
                    break;
                
                case "2":
                    Console.WriteLine("\nFirst choose an entree:");
                    Console.WriteLine("[1] Bowl");
                    Console.WriteLine("[2] Ramen");
                    Console.WriteLine("[3] Sandwich");
                    Console.WriteLine("Type anything else to return to the menu");
                    string EntreeOption = Console.ReadLine();
                        switch (EntreeOption)
                        {
                            case "1":
                                NewBowl();
                            break;

                            case "2":
                                NewRamen();
                            break;

                            case "3":
                                NewSandwich();
                            break;
                                
                            default:   
                                Console.WriteLine("Welcome Back, Roll For Lunch!");
                            break;
                        }
                    break;
                
                case "3":
                    Console.WriteLine("Bye Bye!");
                    running = false;
                    break;
                
                default:   
                    Console.WriteLine("Please enter a valid option!");
                    break;
            }

        }    
    }

    static void ViewCreatedLunches()
    {
        if (CreatedLunches.Count == 0)
        {
            Console.WriteLine("\nNo Lunches created yet.");
        }
        else
        {
            Console.WriteLine("\nCreated Lunches:");
            foreach (string lunch in CreatedLunches)
            {
                Console.WriteLine(lunch);
            }
        }
    }

    static void NewBowl()
    {
        Bowl bowl = new Bowl();
        bowl.CreateBowl();
        string lunch = bowl.ToString();
        CreatedLunches.Add(lunch);

        Console.WriteLine("\nHere's your Bowl!");
        Console.WriteLine(lunch);
    }

    static void NewRamen()
    {
        Ramen ramen = new Ramen();
        ramen.CreateRamen();
        string lunch = ramen.ToString();
        CreatedLunches.Add(lunch);

        Console.WriteLine("\nHere's your Ramen!");
        Console.WriteLine(lunch);
    }

    static void NewSandwich()
    {
        Sandwich sandwich = new Sandwich();
        sandwich.CreateSandwich();
        string lunch = sandwich.ToString();
        CreatedLunches.Add(lunch);

        Console.WriteLine("\nHere's your Sanwhich!");
        Console.WriteLine(lunch);
    }

    public static string Roll(string optionName, string[] options)
    {
        Console.WriteLine($"\nRoll for {optionName} (Enter Anything):");
        Console.WriteLine($"Options: {string.Join(", ",options)}");
        Console.ReadLine(); 

        Random random = new Random();
        int randomIndex = random.Next(options.Length);
        string selectedOption = options[randomIndex];

        Console.WriteLine($"\n{optionName} selected: {selectedOption}");
        return selectedOption;
    }

}