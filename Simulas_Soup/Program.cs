// This is challenge work for the "C# Players Guide"
// Level 17 Simula's Soup Challenge
// The Goal is to use enumerations and tuples to represent soup
// The soup has a total of three variations that a user can select from:
// 1) Type: Soup, stew, gumbo
// 2) Main ingredient: mushrooms, chicken, carrots, or potatoes
// 3) Seasoning: spicy, salty, sweet

//User selection
//(SoupType soup_type, IngredientType Ingreident_type, SeasonType season_type) SelectSoup = GetSoup();

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

Console.WriteLine($"test {Soup_Name}");


// Set Ingredient |--------------------------------------------------------------------|
string Ingredient_Base = "null";
while (Ingredient_Base != "mushrooms" && Ingredient_Base != "chicken" && Ingredient_Base != "carrots" && Ingredient_Base != "potatoes")
{
    Console.WriteLine("What type of main ingredient would you like: Mushrooms, Chicken, Carrots, or Potatoes?");
    Ingredient_Base = Console.ReadLine().ToLower();
}
IngredientType Ingredient_Name = Ingredient_Base switch
{
    "mushrooms" => IngredientType.Mushrooms,
    "chicken" => IngredientType.Chicken,
    "carrots" => IngredientType.Carrots,
    "potatoes" => IngredientType.Potatoes,
};

Console.WriteLine($"test {Ingredient_Name}");


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
Console.WriteLine($"test {Seasoning_Name}");
Console.ReadKey();


//Methods
/*

(SoupType, IngredientType, SeasonType) GetSoup()
{
    Console.WriteLine("Welcome to Simula's Soup Shop");

    //Base
    string Soup_Base = "null";
    while (Soup_Base != "soup" || Soup_Base != "stew" || Soup_Base != "gumbo")
    {

        Console.WriteLine("What type of Soup base would you like: Soup, Stew, or Gumbo?");
        Soup_Base = Console.ReadLine().ToLower();
        Console.WriteLine("error");
    }
        SoupType Soup_Name = Soup_Base switch
        {
            "soup" => SoupType.soup,
            "stew" => SoupType.stew,
            "gumbo" => SoupType.gumbo,
        };
 

*/
// Ingredient
//Console.WriteLine("What type of main Ingredient could you like in your soup?");

//Seasoning
//Console.WriteLine("What type of Seasoning would you like in your soup?");



//}



// Enumerations
enum SoupType { Soup, Stew, Gumbo }
enum IngredientType { Mushrooms, Chicken, Carrots, Potatoes }
enum SeasonType { Spicy, Salty, Sweet }



