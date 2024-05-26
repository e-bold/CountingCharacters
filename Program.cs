

string text= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
char[] charactersArray= text.ToUpper().ToCharArray();


Dictionary<char, int> count=[];
Console.Write("Enter your desired letter: ");
char inputLetter = char.Parse(Console.ReadLine());
string upperCase = inputLetter.ToString();
string uppery = upperCase.ToUpper();
Console.WriteLine(uppery);




foreach(char character in charactersArray)
{


    if(!count.ContainsKey(character) && character.ToString() != " " && character.ToString() != "," && character.ToString() != ".")
    {
        count.Add(character, 1);
        
    }
    else if(char.IsLetter(character))
    {
        count[character]++;
    };

}

foreach(KeyValuePair<char, int> counts in count )
{
    if(counts.Key.ToString() == uppery)
    {
        Console.WriteLine(counts.Key + ": " + counts.Value);
    }
}  


Console.WriteLine("\n-------------\n");


foreach(KeyValuePair<char, int>counts in count)
{
Console.WriteLine(counts.Key + ": " + counts.Value);
}
