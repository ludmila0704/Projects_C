int[] array = {24,54,154,8,5,68,69,4,10};

int n = array.Length;
int find =4;

int index=0;
while (index<n)
{
    if(array[index]==find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}