namespace DiamanteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite um número ímpar: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero % 2 == 0);

            for (int i = 0; i < numero; i++)
            {
                int espaco = Math.Abs(numero / 2 - i); // número de espaços em branco Math.Abs é pra pegar o número absoluto
                int x = numero - 2 * espaco; // número de letras 'x'
                for (int j = 0; j < espaco; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < x; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }
    }

}
