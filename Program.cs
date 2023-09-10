

using Task_PR_Team1;

Console.Write("Enter your favorite counry: ");
string favorCountry = Console.ReadLine();

Console.Write("Enter capitol your favorite counry:");
string capitolCountry = Console.ReadLine();

Countries favorite = new Countries(favorCountry, capitolCountry);

favorite.GiveCountry(favorCountry, capitolCountry);