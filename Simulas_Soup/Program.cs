// This is challenge work for the "C# Players Guide"
// Level 17 Simula's Soup Challenge
// The Goal is to use enumerations and tuples to represent soup
// The soup has a total of three variations that a user can select from:
// 1) Type: Soup, stew, gumbo
// 2) Main ingredient: mushrooms, chicken, carrots, or potatoes
// 3) Seasoning: spicy, salty, sweet

//User selection
//(SoupType soup_type, IngredientType Ingreident_type, SeasonType season_type) SelectSoup = GetSoup();






//Methods
/*
(SoupType, IngredientType, SeasonType) GetSoup()
{
    Console.WriteLine("Welcome to Simula's Soup Shop");
    Console.WriteLine("What type of Soup base would you like: Soup, Stew, or Gumbo?");
    Console.
    Console.WriteLine("What type of main Ingredient could you like in your soup?");
    Console.WriteLine("What type of Seasoning would you like in your soup?");



}*/



// Enumerations
enum SoupType { soup, stew, gumbo }
enum IngredientType { mushrooms, chicken, carrots, potatoes }
enum SeasonType { spicy, salty, sweet }



