using Task_PR_Team1.Classes;
using Task_PR_Team1.marks_folder;

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

Console.WriteLine("Finish home task with PR");

int x = 12321;
var palid = new Palindrome();

bool isPalindrome = palid.IsPalindrome(x);
Console.WriteLine(isPalindrome);

Console.WriteLine("It's Mark's comment");
