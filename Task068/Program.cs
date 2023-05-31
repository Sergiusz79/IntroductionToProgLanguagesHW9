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


int Akerman(int n, int m)
{
    if (n == 0) return m + 1;
    if ((n != 0) && (m == 0)) return Akerman(n - 1, 1);
    else return Akerman(n - 1, Akerman(n, m - 1));
}




void Task068()
{
    int m = EnterNumber("Please enter first number:> ");
    int n = EnterNumber("Please enter second number:> ");

    Console.WriteLine($" Resalt:  {Akerman(m, n)}");
}

Task068();