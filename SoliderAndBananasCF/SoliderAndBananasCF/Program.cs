var inputNumber = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
var price = inputNumber[0];
var tkHave = inputNumber[1];
var totalBanana = inputNumber[2];

var totalMoney = 0;

for(int i = 1; i <= inputNumber[2]; i++)
{
    totalMoney += i * price;
}

if (totalMoney > tkHave)
{
    Console.WriteLine(totalMoney - tkHave);
}
else
{
    Console.WriteLine("0");
}
