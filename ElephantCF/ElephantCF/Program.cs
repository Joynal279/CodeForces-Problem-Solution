var inputNumber = Convert.ToInt32(Console.ReadLine());
var sum = 1;

countStep();
void countStep()
{
    var getNumber = 5 * sum;

    if(getNumber > inputNumber)
    {
        sum = sum - 1;
        var nowNumber = getNumber - 5;
        for (int i = 1; i<=4; i++)
        {
            nowNumber = nowNumber + i;
            if (nowNumber == inputNumber)
            {
                sum += 1;
                Console.WriteLine(sum);
                break;
            }
            else
            {
                nowNumber = nowNumber - i;
            }
        }

        return;


    }

    if(getNumber == inputNumber)
    {
        Console.WriteLine(sum);
        return;
    }

    if(inputNumber==5 || inputNumber < 5)
    {
        Console.WriteLine("1");
        return;
    }

    sum += 1;
    countStep();
}

