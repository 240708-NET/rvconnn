using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

class Program
{
    static List<string> CreatedLunches = new List<string>();
    static string connectionString = "Server=localhost;User Id=sa;Password=NotPassword123!;TrustServerCertificate=True;";

    static void Main(string[] args)
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
                            Console.WriteLine("Returning to main menu...");
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
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM lunches";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    Console.WriteLine("No Lunches created yet.");
                }
                else
                {
                    Console.WriteLine("\nYour Created Lunches:");
                    while (reader.Read())
                    {
                        int lunchID = reader.GetInt32(reader.GetOrdinal("LunchID"));
                        string type = reader.GetString(reader.GetOrdinal("Type"));
                        string details = reader.GetString(reader.GetOrdinal("Details"));

                        Console.WriteLine($"{lunchID}: {type} - {details}");
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    static void NewBowl()
    {
        Bowl bowl = new Bowl();
        bowl.CreateBowl();
        string lunchDetails = bowl.ToString();
        CreatedLunches.Add(lunchDetails);

        Console.WriteLine("\nHere's your Bowl!");
        Console.WriteLine(lunchDetails);

        InsertLunchIntoDatabase("Bowl", lunchDetails);
    }

    static void NewRamen()
    {
        Ramen ramen = new Ramen();
        ramen.CreateRamen();
        string lunchDetails = ramen.ToString();
        CreatedLunches.Add(lunchDetails);

        Console.WriteLine("\nHere's your Ramen!");
        Console.WriteLine(lunchDetails);

        InsertLunchIntoDatabase("Ramen", lunchDetails);
    }

    static void NewSandwich()
    {
        Sandwich sandwich = new Sandwich();
        sandwich.CreateSandwich();
        string lunchDetails = sandwich.ToString();
        CreatedLunches.Add(lunchDetails);

        Console.WriteLine("\nHere's your Sandwich!");
        Console.WriteLine(lunchDetails);

        InsertLunchIntoDatabase("Sandwich", lunchDetails);
    }

    public static string Roll(string optionName, string[] options)
    {
        Console.WriteLine($"\nRoll for {optionName} (Enter Anything):");
        Console.WriteLine($"Options: {string.Join(", ", options)}");
        Console.ReadLine();

        Random random = new Random();
        int randomIndex = random.Next(options.Length);
        string selectedOption = options[randomIndex];

        Console.WriteLine($"\n{optionName} selected: {selectedOption}");
        return selectedOption;
    }

    static void InsertLunchIntoDatabase(string type, string details)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO lunches (Type, Details) VALUES (@Type, @Details)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@Details", details);

                command.ExecuteNonQuery();
                Console.WriteLine("Lunch added to database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
