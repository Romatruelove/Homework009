Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N (должно быть больше M)");
int n = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int m, int n) 
{
    if (m > n) return 0;
    return m + SumNumbers(m+1, n);
}
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {SumNumbers(m, n)}");