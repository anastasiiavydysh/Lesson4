Console.Write("Enter your word in Ukrainian -> ");
string word = Console.ReadLine().ToLower();

switch(word)
{
    case "погода":
        Console.WriteLine("Weather");
        break;
    case "сонячно":
        Console.WriteLine("Sunny");
        break;
    case "похмуро":
        Console.WriteLine("Gloomily");
        break;
    case "дощ":
        Console.WriteLine("Rainy");
        break;
    case "туман":
        Console.WriteLine("Foggy");
        break;
    case "сніг":
        Console.WriteLine("Snow");
        break;
    case "холодно":
        Console.WriteLine("Cold");
        break;
    case "тепло":
        Console.WriteLine("Hot");
        break;
    case "іній":
        Console.WriteLine("Frost");
        break;
    case "вологість":
        Console.WriteLine("Humidity");
        break;
    default:
        Console.WriteLine("Sorry, I don't know this word :(");
        break;
}