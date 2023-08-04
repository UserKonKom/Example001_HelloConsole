int[] array = { 11, 22, 33, 14, 56, 61, 75, 14 };

int n = array.Length;
int find = 14;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    /*index = index + 1;*/
    index++;
}
