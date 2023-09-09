using Task_PR_Team1.Classes;

Console.Write("Enter your name: ");
var name = Console.ReadLine();

Console.Write("Enter your surname: ");
var surname = Console.ReadLine();

PersonalInfo personalInfo = new PersonalInfo(name, surname);
var info = personalInfo.GetUserInfo();
Console.WriteLine(info);