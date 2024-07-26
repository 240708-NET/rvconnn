class Ramen
{
    public string Broth { get; set; }
    public string Main { get; set; }
    public string Green { get; set; }
    public string Extra { get; set; }
    public string SpecialAddition { get; set; }

    public void CreateRamen()
    {
        string[] BrothOptions = { "Chicken", "Vegetable", "Beef", "Seafood", "Pork", "Chili" };
        string[] MainOptions = { "Egg", "Tofu", "Chicken", "Beef", "Fish", "Pork" };
        string[] GreenOptions = { "Baby Bok Choy", "Spinach", "Napa Cabbage", "Lettuce", "Cilantro", "Green Onion" };
        string[] ExtraOptions = { "Bean Sprouts", "Mushrooms", "Green Beans", "Corn", "Tomatoes", "Veggie Variety" };
        string[] SpecialAdditionOptions = { "Peanut Butter", "Cheese", "Siracha", "Hoisin", "Kewpie Mayo", "Coconut Milk" };

        Broth = Program.Roll("Broth", BrothOptions);
        Main = Program.Roll("Main", MainOptions);
        Green = Program.Roll("Green", GreenOptions);
        Extra = Program.Roll("Extra", ExtraOptions);
        SpecialAddition = Program.Roll("Special Addition", SpecialAdditionOptions);
    }

    public override string ToString()
    {
        return $"Ramen with {Broth} broth, {Main}, {Green}, {Extra}, and {SpecialAddition}!";
    }
}
