// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


int EnterNumber(string text)
{
    int number;
    Console.WriteLine(text);
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("This is not number. Please enter number.");
    }
    return number;
}


int WriteIntegers(int m, int n)
{
    if (m < n) return m + WriteIntegers(m + 1, n);
    if (m > n) return n + WriteIntegers(m, n + 1);
    else return m;
} 



void Task066()
{
    int m = EnterNumber("Please enter first number:> ");
    int n = EnterNumber("Please enter second number:> ");

    Console.WriteLine(WriteIntegers(m, n));
}

Task066();