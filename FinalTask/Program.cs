string[] array = new string[] { "blue", "red", "white", "gren" };
Console.WriteLine("Enter String length");
int StringLength = Convert.ToInt32(Console.ReadLine());

int FindNextArrayLength(string[] arr, int n)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= n)
        {
            count += 1;
        }
    }
    return count;
}

string[] CreateNewArray(string[] arr, int newArrlength, int n)
{

    string[] newarray = new string[newArrlength];
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= n)
        {
            newarray[j] = arr[i];
            j++;
        }
    }
    return newarray;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");

    }
}

int arraylength = FindNextArrayLength(array, StringLength);
Console.WriteLine($"The array lenght is {arraylength}");
string[] Result = CreateNewArray(array, arraylength, StringLength);
PrintArray(Result);
