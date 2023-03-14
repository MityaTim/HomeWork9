PrintNumbers(Convert.ToInt32(Console.ReadLine()));

void PrintNumbers(int n)
{
    if (n < 1) return;
    Console.Write(n + " ");
    PrintNumbers(n - 1);
}