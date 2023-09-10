using Task_PR_Team1.Classes;

Console.Write("Enter your name: ");
var name = Console.ReadLine();

Console.Write("Enter your surname: ");
var surname = Console.ReadLine();

PersonalInfo personalInfo = new PersonalInfo(name, surname);
var info = personalInfo.GetUserInfo();
Console.WriteLine(info);

Console.Write("Enter your favorite counry: ");
string favorCountry = Console.ReadLine();

Console.Write("Enter capitol your favorite counry:");
string capitolCountry = Console.ReadLine();

Countries favorite = new Countries(favorCountry, capitolCountry);

favorite.GiveCountry(favorCountry, capitolCountry);

