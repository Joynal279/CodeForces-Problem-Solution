var loopNumber = Convert.ToInt32(Console.ReadLine());
var sum = 0;
for (int i = 0; i<loopNumber; i++)
{
    var inputBit = Console.ReadLine();
    if (inputBit == "++X" || inputBit == "X++")
    {
        sum = sum + 1;
    }

    if (inputBit == "--X" || inputBit == "X--")
    {
        sum = sum - 1;
    }
}
Console.WriteLine(sum);
