using System.Linq;


string [] Array = {"Moscow", "Tor", "Saint-Petersburg", "Vasilek", "23"};
int n = 0;
string [] NewArray = new string [n];

for (int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length < 4)
    {
        n++;
    
        // NewArray [i] = Array[i];
        // Console.WriteLine(NewArray[i]);
    }
}
Console.WriteLine(n);