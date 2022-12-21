Console.WriteLine("Введите целое неотрицательное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое неотрицательное число N");
int n = Convert.ToInt32(Console.ReadLine());
int Ackermann(int m, int n)
{
    if (m == 0) { return n + 1; }
    else if (m != 0 && n == 0) { return Ackermann(m - 1, 1); }
    else { return Ackermann(m - 1, Ackermann(m, n - 1)); }
    return Ackermann(m, n);
}
Console.WriteLine($"{Ackermann(m, n)}");