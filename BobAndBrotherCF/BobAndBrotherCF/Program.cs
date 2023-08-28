var weightInput = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
var firstWeight = weightInput[0];
var secondWeight = weightInput[1];

var sum = 0;

returnYear();
 void returnYear()
{
    firstWeight = firstWeight * 3;
    secondWeight = secondWeight * 2;

    sum += 1;

    if (firstWeight > secondWeight)
    {
        Console.WriteLine(sum);
        return;
    }
    returnYear();
}

