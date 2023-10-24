int[] array = {1,2,3,4,27,27,27,18};

int n = array.Length;
int find = 27;
int index = 0;

while(index < n)
{   
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}