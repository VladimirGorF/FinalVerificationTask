string[] Array = { "Moscow", "Tor", "Saint-Petersburg", "Vasilek", "23", "Z", "Bur" };
int n = 0;

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length < 4) n++;
}
string[] NewArray = new string[n];

void FillNewArray()
{
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length < 4)
        {
            NewArray[j] = Array[i];
            j++;
        }
    }
}

void PrintNewArray()
{
    for (int i = 0; i < NewArray.Length; i++)
    {
        if (i < NewArray.Length - 1) Console.Write($"{NewArray[i]}, ");
        else Console.Write(NewArray[i]);
    }
    Console.WriteLine();
}

FillNewArray();
PrintNewArray();


