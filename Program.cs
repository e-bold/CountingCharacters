

string text= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
char[] charactersArray= text.ToCharArray();


Dictionary<char, int> count=[];
foreach(char character in charactersArray)
{
    if(!count.ContainsKey(character))
    {
        count.Add(character, 1);
    }
    else if(char.IsLetter(character))
    {
        count[character]++;
    };

}


foreach(KeyValuePair<char, int>counts in count)
{
Console.WriteLine(counts.Key + ": " + counts.Value);
}
asdfasdf