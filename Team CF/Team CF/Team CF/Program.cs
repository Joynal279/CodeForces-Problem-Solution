var inputTimes = Convert.ToInt16(Console.ReadLine());

var outerSum = 0;

for (int j = 0; j < inputTimes; j++)
{
    var innerSum = 0;
    var firstInput = Console.ReadLine();

    var firstNumber = firstInput.Substring(0, 1);
    var secondNumber = firstInput.Substring(2, 2);
    var thiredNumber = firstInput.Substring(firstInput.Length - 1);

    if (Convert.ToInt16(firstNumber) == 1)
    {
        innerSum += 1;
    }

    if (Convert.ToInt16(secondNumber) == 1)
    {
        innerSum += 1;
    }

    if (Convert.ToInt16(thiredNumber) == 1)
    {
        innerSum += 1;
    }

    if (innerSum >= 2)
    {
        outerSum += 1;
    }

}

Console.WriteLine(outerSum);


