
int GetNewSize(string[] arr)
{
    int newSizeTmp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) newSizeTmp++;
    }
    return newSizeTmp;
}

void FillNewArray(string[] arrayForFill, string[] fillingArray)
{
    int i = 0, j = 0;
    while (i < fillingArray.Length && j < arrayForFill.Length)
    {
        if (fillingArray[i].Length <= 3)
        {
            arrayForFill[j] = fillingArray[i];
            j++;
        }
        i++;
    }
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"\"{arr[i]}\", ");
    }
    Console.Write($"\"{arr[arr.Length - 1]}\"]");
}



int arrayLength = 0;

while(arrayLength <= 0)
{
    Console.WriteLine("Enter number of strings: ");
    arrayLength = Convert.ToInt32(Console.ReadLine());
    if(arrayLength<0)
    {
        Console.WriteLine("It can't be 0 or less! Try again!");
    }
}

string[] stringsArr = new string[arrayLength];

for (int i = 0; i < arrayLength; i++)
{
    Console.WriteLine($"Enter {i+1} string: ");
    stringsArr[i] = Console.ReadLine();
}

int newSize = GetNewSize(stringsArr);
if(newSize > 0)
{
    string[] newStringsArr = new string[newSize];
    FillNewArray(newStringsArr, stringsArr);
    PrintArray(stringsArr);
    Console.Write( " -> ");
    PrintArray(newStringsArr);
}
else
{
    PrintArray(stringsArr);
    Console.Write( " -> []");
}