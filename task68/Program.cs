Console.WriteLine(
    A(
        Convert.ToInt32(Console.ReadLine()),
        Convert.ToInt32(Console.ReadLine())
    )
);

int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return A(n - 1, 1);

    return A(n - 1, A(n, m - 1));
}
