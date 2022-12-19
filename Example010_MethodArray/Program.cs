int[] array = { 11, 214, 31, 49, 54, 65, 72, 83, 49};

int n = array.Length;
int find = 49;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

