using System;

namespace Vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine(" ----- PROJETO VENDAS -----\n");
                Console.WriteLine(" 1 Cadastrar Cliente");
                Console.WriteLine(" 2 Listar Cliente");
                Console.WriteLine(" 0 Sair\n");
                Console.WriteLine(" Escolha uma opção: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("-- Cadastrar Cliente --");

                        break;
                    case 2:
                        Console.WriteLine("-- Listar Clientes --");
                        break;
                    case 0:
                        Console.WriteLine("-- Saindo --");
                        break;
                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA, tente de novo.");
                        break;
                }
                Console.WriteLine("\nAperte uma tecla para continuar ");
                Console.ReadKey();
            } while (op != 0);
           
        }
    }
}
