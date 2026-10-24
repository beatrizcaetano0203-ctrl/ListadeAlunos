namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double resultado, num1, num2;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operacao desejada(+, -, *, /):");
            string? operacao = Console.ReadLine();

            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                    break;

                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                    break;

                case "*":

                    if (num2 == 0)
                    {
                        Console.WriteLine("ERRO: Não é possível dividir por zero!");
                    }
                    else
                    {
                        resultado = num1 % num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                    }
                    break;


                case "/":

                    if (num2 == 0)
                    {
                        Console.WriteLine("ERRO: Não é possível dividir por zero!");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                    }
                    break;

                case "%":

                    if (num2 == 0)
                    {
                        Console.WriteLine("ERRO: Não é possível dividir por zero!");
                    }
                    else
                    {
                        resultado = num1 % num2;
                        Console.WriteLine($"Resultado: {num1} % {num2} = {resultado}");
                    }
                    break;

                default:
                    Console.WriteLine("OPERAÇÃO INVÁLIDA");
                    break;
            }

            


        }
    }
}
