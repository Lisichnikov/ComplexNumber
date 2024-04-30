class Program
{
    static void Main(string[] args)
    {
        ComplexNumber a = new ComplexNumber(2, 3);
        ComplexNumber b = new ComplexNumber(4, -1);

        ComplexNumber sum = a + b;
        ComplexNumber difference = a - b;
        ComplexNumber product = a * b;
        ComplexNumber quotient = a / b;

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"a + b = {sum}");
        Console.WriteLine($"a - b = {difference}");
        Console.WriteLine($"a * b = {product}");
        Console.WriteLine($"a / b = {quotient}");
    }
}