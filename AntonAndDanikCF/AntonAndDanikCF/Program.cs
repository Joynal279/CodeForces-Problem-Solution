
var loopNumber = Convert.ToInt64(Console.ReadLine());
var inputString = Console.ReadLine().ToUpper();
var antonCount = 0;
var danikCount = 0;

for (int i = 0; i < loopNumber; i++)
{
    if (inputString[i] == 'A')
    {
        antonCount += 1;
    }
    if (inputString[i] == 'D')
    {
        danikCount += 1;
    }
}
if(antonCount == danikCount)
{
    Console.WriteLine("Friendship");
}
if (antonCount > danikCount)
{
    Console.WriteLine("Anton");
}
if (danikCount > antonCount)
{
    Console.WriteLine("Danik");
}
