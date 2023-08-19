var row = 0;
var colum = 0;

for(int i=0; i<5; i++)
{
    var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
    for (int j=0; j<5; j++)
    {
        if (arr[j] == 1)
        {
            row = i+1;
            colum = j+1;
        }
    }
}

var rowStep = Math.Abs(3 - row);
var columnStep = Math.Abs(3 - colum);
Console.WriteLine(rowStep + columnStep);

