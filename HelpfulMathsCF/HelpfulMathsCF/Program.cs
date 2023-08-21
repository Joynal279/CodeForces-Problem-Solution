var a = Array.ConvertAll(Console.ReadLine().Trim().Split('+'), Convert.ToInt32);

for (int i = 0; i < a.Count(); i++)
{
    for (int j = 0; j < (a.Count() - 1); j++)
    {
        if (a[j] > a[j + 1])
        {
            int temp = a[j];
            a[j] = a[j + 1];
            a[j + 1] = temp;
        }
    }
}

for (int i = 0; i < a.Length; i++)
{
    if (i == a.Length-1)
    {
        Console.Write(a[i]);
    }
    else
    {
        Console.Write(a[i] + "+");
    }
}