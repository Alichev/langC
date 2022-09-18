int[] array = { 14, 2, 37, 40, 5, 62, 27, 84, 91 };
int n = array.Length;
int find = 84;
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