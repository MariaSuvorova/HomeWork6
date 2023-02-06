/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
вводим через один Enter (разбиваем через Split()) */

int[] CreateArrayOfNumbers(string line)
{
    string[] arrayOfChar = line.Split(" ");
    int[] arrayOfNumbers = new int[arrayOfChar.Length];
    for (int i = 0; i < arrayOfChar.Length; i++)
    {
        arrayOfNumbers[i] = Convert.ToInt32(arrayOfChar[i]);
    }
    return arrayOfNumbers;
}

int PositivNumberCount(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            count += 1;
    }
    return count;
}

Console.WriteLine("Введите целые числа через пробел");
string numbersInLine = Console.ReadLine();
int[]  numbers = CreateArrayOfNumbers(numbersInLine);
int positivDigit = PositivNumberCount(numbers);
Console.WriteLine($"введено чисел больше 0: {positivDigit}");

