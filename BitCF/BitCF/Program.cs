var loopNumber = Convert.ToInt32(Console.ReadLine());
var sum = 0;
for (int i = 0; i<loopNumber; i++)
{
    var inputBit = Console.ReadLine();
    if (inputBit == "++x" || inputBit == "x++")
    {
        sum = sum + 1;
    }

    if (inputBit == "--x" || inputBit == "x--")
    {
        sum = sum - 1;
    }
}
Console.WriteLine(sum);
