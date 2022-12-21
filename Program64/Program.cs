Console.WriteLine("Введите целое число N:");
int N = Convert.ToInt32(Console.ReadLine());
int NumbersSequence(int N)
{
    if (N == 1) return 1;
    Console.Write($"{N} ");
    return NumbersSequence(N-1);
}
Console.WriteLine(NumbersSequence(N));