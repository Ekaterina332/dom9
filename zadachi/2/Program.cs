// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();

int OutPutNumber(int Number1, int Number2, int sum)
{
    sum = sum + Number2; 
    if (Number2 <= Number1)
        return sum;
    return OutPutNumber(Number1, Number2 - 1, sum);
}

Console.Write("Введите 2 числа : ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int sum = 0;
Console.Write(OutPutNumber(numbers[0], numbers[1], sum));
