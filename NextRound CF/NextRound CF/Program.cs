var foundNumber = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

var range = foundNumber[1];
var inputRange = foundNumber[0];

int[] arr = new int[inputRange];

arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

var positionNumber = arr[range - 1];

var sum = 0;

for (int i = 0; i < arr.Count(); i++)
{
    if (arr[i] >= positionNumber && arr[i] > 0)
    {
        sum += 1;
    }
}
Console.WriteLine(sum);


