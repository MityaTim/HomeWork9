int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(
    Enumerable.Range(a, b - a + 1)
        .Sum()
);