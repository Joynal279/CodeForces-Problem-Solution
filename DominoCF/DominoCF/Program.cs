var inputNumber = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
var firstNumber = inputNumber[0];
var secondNumber = inputNumber[1];
var answer = (firstNumber * secondNumber) / 2;
Console.WriteLine(answer);