// This is challenge work for the "C# Players Guide"
// Level 17 Simula's Soup Challenge
// The Goal is to use enumerations and tuples to represent soup
// The soup has a total of three variations that a user can select from:
// 1) Type: Soup, stew, gumbo
// 2) Main ingredient: mushrooms, chicken, carrots, or potatoes
// 3) Seasoning: spicy, salty, sweet

//User selection
(SoupType soup_type, IngredientType Ingreident_type, SeasonType season_type) SelectSoup = MakeSoup();

//Final output
Console.WriteLine($"\nYou ordered: {SelectSoup.season_type} {SelectSoup.Ingreident_type} {SelectSoup.soup_type}");
Console.ReadKey();


//Method
(SoupType, IngredientType, SeasonType) MakeSoup()
{
    Console.WriteLine("Welcome to Simula's Soup Shop");

    // Set Base |--------------------------------------------------------------------|
    string Soup_Base = "null";
    while (Soup_Base != "soup" && Soup_Base != "stew" && Soup_Base != "gumbo")
    {
        Console.WriteLine("What type of Soup base would you like: Soup, Stew, or Gumbo?");
        Soup_Base = Console.ReadLine().ToLower();
    }
    SoupType Soup_Name = Soup_Base switch
    {
        "soup" => SoupType.Soup,
        "stew" => SoupType.Stew,
        "gumbo" => SoupType.Gumbo,
    };
    
    // Set Ingredient |--------------------------------------------------------------------|
    string Ingredient_Base = "null";
    while (Ingredient_Base != "mushroom" && Ingredient_Base != "chicken" && Ingredient_Base != "carrot" && Ingredient_Base != "potato")
    {
        Console.WriteLine("What type of main ingredient would you like: Mushroom, Chicken, Carrot, or Potato?");
        Ingredient_Base = Console.ReadLine().ToLower();
    }
    IngredientType Ingredient_Name = Ingredient_Base switch
    {
        "mushroom" => IngredientType.Mushroom,
        "chicken" => IngredientType.Chicken,
        "carrot" => IngredientType.Carrot,
        "potato" => IngredientType.Potato,
    };

    // Set Seasoning |--------------------------------------------------------------------|
    string Seasoning_Base = "null";
    while (Seasoning_Base != "spicy" && Seasoning_Base != "salty" && Seasoning_Base != "sweet")
    {
        Console.WriteLine("What type of seasoning would you like: Spicy, Salty, or Sweet?");
        Seasoning_Base = Console.ReadLine().ToLower();
    }
    SeasonType Seasoning_Name = Seasoning_Base switch
    {
        "spicy" => SeasonType.Spicy,
        "salty" => SeasonType.Salty,
        "sweet" => SeasonType.Sweet,
    };
    return (Soup_Name, Ingredient_Name, Seasoning_Name);
}

// Enumerations
enum SoupType { Soup, Stew, Gumbo }
enum IngredientType { Mushroom, Chicken, Carrot, Potato }
enum SeasonType { Spicy, Salty, Sweet }