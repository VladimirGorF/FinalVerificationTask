using System.Linq;


string [] Array = {"Moscow", "Tor", "Saint-Petersburg", "Vasilek", "23", "Z", "Bur"};
int n = 0;

for (int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length < 4)
    {
        n++;
    }
}

string [] NewArray = new string [n];
int j = 0;
for (int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length < 4)
    {
        NewArray [j] = Array[i];
        Console.WriteLine(NewArray[j]);
        j++;
    } 
}