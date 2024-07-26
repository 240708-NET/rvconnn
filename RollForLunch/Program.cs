class Program
{

    
    static void Main( string[] args )
    {
        
        //I want to create a console app that creates lunches for the user
        //option 1 will allow the user to view all past created meals(data persistance)
        //option 2 will allow the user to choose between three different entree items: Salad, Sandwhich, Ramen
        //After selecting an entree it will take the user through different aspects of the item, e.g. for sandwhich: bread, main item, cheese
        //the user will first see all of the bread options and enter for the app to randomly choose one of the options
        //after going through each option, the app will list the choices for the completed item and will cycle back to the option menu

        Console.WriteLine("Welcome to Roll for Lunch!");
        Console.WriteLine("Let RNG decide your next lunchtime meal!");
        
        bool running = true;    
        while (running)
        {    
            Console.WriteLine("Please select an option.");
            Console.WriteLine("[1] View all created meals.");
            Console.WriteLine("[2] Create a new Lunch.");
            Console.WriteLine("[3] Exit");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("option 1");
                    break;
                case "2":
                    Console.WriteLine("option 1");
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

}