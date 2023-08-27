var inputNumber = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
var firstNumber = inputNumber[0];
var secondNumber = inputNumber[1];

for(int i = 1; i<=secondNumber; i++)
{
    if (firstNumber % 10 == 0)
    {
        firstNumber = firstNumber / 10;
    }
    else
    {
        firstNumber = firstNumber - 1;
    }
}
Console.WriteLine(firstNumber);
