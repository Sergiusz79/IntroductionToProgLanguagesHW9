// Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"


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



string WriteIntegersP(int m, int n)
{
    if (m <= n) return $"{m} " + WriteIntegersP(m + 1, n);
    else return String.Empty;
}
string WriteIntegersN(int m, int n)
{
   if (m >= n) return WriteIntegersN(m, n + 1) + $"{n} ";
    else return String.Empty;
}

void Task064()
{
    int m = EnterNumber("Please enter first number:> ");
    int n = EnterNumber("Please enter second number:> ");
    
    if (m <= n) System.Console.WriteLine(WriteIntegersP(m, n));
    if (m >= n) System.Console.WriteLine(WriteIntegersN(m, n));
}

Task064();