int[] array = { 1,2,13,4,25,6,7,8 };

int n = array.Length;

int find = 25;
int index =0;

while (index<n)
{

    if (array [index] == find)
    {
       Console.WriteLine (index);
    }
    index= index+1;
}