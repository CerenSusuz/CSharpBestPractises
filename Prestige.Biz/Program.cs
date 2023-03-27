internal class Program
{
    public const int ConstantNumber = 100;

    static readonly int ReadOnlyNumber = 0;

    static Program()
    {
        ReadOnlyNumber = 1; // assign just on constructor
    }

    private static void Main(string[] args)
    {
        Console.WriteLine(ConstantNumber);
        Console.WriteLine(ReadOnlyNumber);
    }
}