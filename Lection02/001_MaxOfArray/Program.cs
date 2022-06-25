int Max(int[] array)
{
    int result = array[0];
    foreach (int i in array)
    {
        if (i > result)
        {
            result = i;
        }
    }
    return result;   
}

int[] array = {11, 32, 34, 45, 56, 67, 72, 84, 92};
Console.Write(Max(array));