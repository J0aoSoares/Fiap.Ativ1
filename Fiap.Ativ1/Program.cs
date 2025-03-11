using System;

namespace FiapAtiv1
{
    class Program
    {
        static void INSS()
        {
            Console.WriteLine("\n=== CALCULAR INSS ===");

            int idade = Verificaidade();
            char genero = Verificagenero();

            int Idadeaposenta = genero == 'M' ? 65 : 62;
            int tempo = Idadeaposenta - idade;

            Console.WriteLine(tempo > 0 ?
                $"Faltam {tempo} anos para você conseguir se aposentar" :
                "Você já pode se aposentar!");
        }

        static void Main(string[] args)
        {
            if (login())
            {
                INSS();
            }
            else
            {
                Console.WriteLine("Falha no Login. Por favor tente novamente.");
            }
        }

        static bool login()
        {
            Console.WriteLine("===== LOGIN =====");
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Senha: ");
            string senha = Console.ReadLine();

            return email == "rm551410@fiap.com.br" && senha == "RM551410";
        }

        static int Verificaidade()
        {
            int idade;
            while (true)
            {
                Console.Write("Digite sua idade: ");
                if (int.TryParse(Console.ReadLine(), out idade) && idade > 0)
                    return idade;

                Console.WriteLine("Idade inválida! Tente novamente.");
            }
        }

        static char Verificagenero()
        {
            while (true)
            {
                Console.Write("Gênero (M/F): ");
                char genero = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (genero == 'M' || genero == 'F')
                    return genero;

                Console.WriteLine("Opção inválida! Use M ou F por favor.");
            }
        }
    }
}