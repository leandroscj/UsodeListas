using System;
using System.Collections.Generic;
using Uso_de_listas;

namespace Usodelistas
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Quantos dados serão inseridos? ");
            var qtd_de_dados = int.Parse(Console.ReadLine());
            List<Funcionarios> funcionario = new List<Funcionarios>();

            for (int i = 0; i < qtd_de_dados; i++)
            {
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                funcionario.Add(new Funcionarios(id, nome, salario));
            }

            Console.Write("Qual o ID do funcionario que vai ser aumentado o salário? ");
            int digitado = int.Parse(Console.ReadLine());

            Funcionarios find = funcionario.Find(x => x.Id == digitado);

            if (find != null)
            {
                Console.Write("Qual a porcentagem do aumento? ");
                double porcentagem = double.Parse(Console.ReadLine());
                find.Acrescentar(porcentagem);
            }
            else
            {
                Console.WriteLine("Este ID não existe!");
            }
            foreach (Funcionarios obj in funcionario)
            {
                Console.WriteLine(obj);
            }
        }
    }
}