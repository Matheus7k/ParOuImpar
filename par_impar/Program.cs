internal class Program
{
    static string ParOuImpar(float numero)
    {
        if (numero % 2 == 0)
        {
            return $"O numero {numero} é par";
        }
        else return $"O numero {numero} é impar";
    }
    private static void Main(string[] args)
    {
        float n1;
        Console.Write("Informe o numero: ");
        n1 = float.Parse(Console.ReadLine());

        Console.WriteLine(ParOuImpar(n1));
    }
}