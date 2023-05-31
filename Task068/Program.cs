// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29


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



// string WriteIntegersN(int m, int n)
// {
//     if (m < n) return $"{m} " + WriteIntegers(m + 1, n);

//     else return $"{m}";

//     //if (m > n) return n + WriteIntegers(m, n + 1);
// } 

int WriteIntegers(int m, int n)
{
    if (m < n) return m + WriteIntegers(m + 1, n);
    if (m > n) return n + WriteIntegers(m, n + 1);
    else return m;

    //if (m > n) return n + WriteIntegers(m, n + 1);
} 



void Task066()
{
    int m = EnterNumber("Please enter first number:> ");
    int n = EnterNumber("Please enter second number:> ");

    System.Console.WriteLine(WriteIntegers(m, n));
}

Task066();