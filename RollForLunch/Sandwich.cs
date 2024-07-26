class Sandwich
{
    public string Bread { get; set; }
    public string Sauce { get; set; }
    public string Main { get; set; }
    public string Cheese { get; set; }
    public string Extra { get; set; }

    public void CreateSandwich()
    {
        string[] BreadOptions = { "white", "Wheat", "Rye", "Brioche", "Ciabatta", "Pumpernickel" };
        string[] SauceOptions = { "Ketchup", "Chipotle Mayo", "Chick-Fil-A Sauce", "Mustard", "Barbecue", "Mayo" };
        string[] MainOptions = { "Ham", "Turkey", "Chicken", "Salami", "Pork", "Tuna" };
        string[] CheeseOptions = { "American", "Provolone", "Swiss", "Cheddar", "Gouda", "Pepper Jack" };
        string[] ExtraOptions = { "Tomato", "Lettuce", "Avocado", "Mushrooms", "Onion", "Doritos" };

        Bread = Program.Roll("Bread", BreadOptions);
        Sauce = Program.Roll("Sauce", SauceOptions);
        Main = Program.Roll("Main", MainOptions);
        Cheese = Program.Roll("Cheese", CheeseOptions);
        Extra = Program.Roll("Extra", ExtraOptions);
    }

    public override string ToString()
    {
        return $"Sandwich on {Bread} bread, with {Sauce}, {Main}, {Cheese}, and {Extra}!";
    }
}
