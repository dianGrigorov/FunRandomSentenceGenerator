

string[] names = { "Dido", "Rali", "Venci", "Niki", "Biba", "Gosho", "Habibi" };
string[] places = { "Rqhovo", "Dobai", "Sofiq", "Trun", "Kaspichan"};
string[] verbs = { "drink", "eats", "fly", "junps", "play with", "hide", "go to"};
string[] nouns = { "house", "cake", "phone", "dog", "bathroom", "river", "car"};
string[] adverbs = { "slowly", "rapidly", "warmly", "sadly"};
string[] details = { "to the moon", "at home", "on my way", "in the forest", "on the river"};


static string GetRandomWord(string[] words)
{
    Random random = new Random();
    int randomIndex = random.Next(words.Length);
    string word = words[randomIndex];
    return word;
}

Console.WriteLine("This is funy randon-sentence generator!");

while (true)
{
    string randomName = GetRandomWord(names);
    string randomPlaces = GetRandomWord(places);
    string randomVerbs = GetRandomWord(verbs);
    string randomNouns = GetRandomWord(nouns);
    string randomAdverbs = GetRandomWord(adverbs);
    string randomDetails = GetRandomWord(details);

    string who = $"{randomName} from {randomPlaces}";
    string actions = $"{randomAdverbs} {randomVerbs} {randomNouns}";
    string sentence = $"{who} {actions} {randomDetails}";

    Console.WriteLine(sentence);
    Console.WriteLine("Press [Enter] to generate new one.");
    
    Console.ReadKey();
    
   
    
}