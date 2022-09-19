
string[] array = new string[] { "blue", "red", "white", "gren" };
int StringLength = 3;

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


