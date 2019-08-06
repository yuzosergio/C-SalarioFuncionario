using System;
using System.Globalization;

namespace POOSalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Digite o nome: ");
            f.nome = Console.ReadLine();

            Console.WriteLine("Digite o salario: ");
            f.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o imposto: ");
            f.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(f);

            Console.WriteLine("Digite a % para o aumento: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.Aumento(porcentagem);

            Console.WriteLine("Dados atualizados: {0}",f);
            Console.ReadKey();



        }
    }
}
