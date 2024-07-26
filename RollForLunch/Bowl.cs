class Bowl
{
    public string Base { get; set; }
    public string Main { get; set; }
    public string Side1 { get; set; }
    public string Side2 { get; set; }
    public string Dressing { get; set; }

    public void CreateBowl()
    {
        string[] BaseOptions = { "White Rice", "Kale", "Quinoa", "Romaine", "Cabbage", "Brown Rice" };
        string[] MainOptions = { "Chicken", "Tofu", "Egg", "Spam", "Salmon", "Tuna" };
        string[] Side1Options = { "Sweet Potatoes", "Apples", "Cucumber", "Broccoli", "Carrots", "Chickpeas" };
        string[] Side2Options = { "Avocado", "Tomatoes", "Blue Cheese", "Corn", "Pickled Onions", "Croutons" };
        string[] DressingOptions = { "Balsamic", "Cesar", "Ranch", "Italian", "Blue Cheese", "Thousand Island" };

        Base = Program.Roll("Base", BaseOptions);
        Main = Program.Roll("Main", MainOptions);
        Side1 = Program.Roll("Side 1", Side1Options);
        Side2 = Program.Roll("Side 2", Side2Options);
        Dressing = Program.Roll("Dressing", DressingOptions);
    }

    public override string ToString()
    {
        return $"Bowl with {Base}, {Main}, {Side1}, {Side2}, and {Dressing} dressing on top!";
    }
}
