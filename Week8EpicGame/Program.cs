using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

string folderPath = @"C:\data\";
string heroFile = "heroes.txt";
string villianFile = "villains.txt";

//string[] heroes = File.ReadAllLines(@"C:\data\heroes.txt");
string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villianFile));


//string[] heroes = { "Kangelane 1", "Kangelane 2", "Kangelane 3", "Kangelane 4" };
//string[] villains = { "Kurikael 1", "Kurikael 2", "Kurikael 3", "Kurikael 4", "Kurikael 5" };
string[] weapons = { "wep1", "weap2", "weap3", "wep4", "weap5" };


string hero = getRandomValueFromArray(heroes);
string weapon = getRandomValueFromArray(weapons);
int heroHP = GetCharacterHP(hero);
int heroStrikeSterngth = heroHP;
Console.WriteLine($"Tänane kangelane on {hero} ({heroHP} HP), relvaga {weapon}");


string villian = getRandomValueFromArray(villains);
string villianWeapon = getRandomValueFromArray(weapons);
int villianHP = GetCharacterHP(villian);
int villianStrikeStrength = villianHP;
Console.WriteLine($"Täanane kutikael on {villian} ({villianHP} HP), relvaga {villianWeapon}");

while (heroHP > 0 && villianHP >0)
{
    heroHP = heroHP - Hit (villian, villianStrikeStrength);
    villianHP =villianHP - Hit (hero, heroStrikeSterngth);

}

Console.WriteLine($"{hero} HP: {heroHP}");
Console.WriteLine($"{villian} HP: {villianHP}");
if (heroHP > 0)
{
    Console.WriteLine($"{hero} saves the day!");
    }
else if (villianHP > 0)
{ Console.WriteLine("Dark side wins"); }

else
{
    { Console.WriteLine("Draw!"); }
}

static string getRandomValueFromArray(string[] anystring)
{

    Random rnd = new Random();
    int randomIndex=rnd.Next(0, anystring.Length);
    string randomStringfromArry = anystring[randomIndex];
    return randomStringfromArry;
        
        }

static int GetCharacterHP(string characterName)
{
    if (characterName.Length < 10)
    {
        return 10;
    }
    else
    {
    return characterName.Length;
    }

}

static int Hit(string characterName, int characterHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, characterHP);

    if (strike == 0)
    {
        Console.WriteLine($"{characterName} missed target!");
    }

    else if (strike == characterHP - 1)
        {
            Console.WriteLine($"{characterName} MarshalDirectiveException a critical hit!");
        }

        else
        {
            Console.WriteLine($"{characterName} hit {strike}!");
        }
        return strike;
    }


