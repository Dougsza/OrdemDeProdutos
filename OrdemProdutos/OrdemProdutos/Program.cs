using System;

namespace OrdemProdutos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o seu nome:");
            string clientName = Console.ReadLine();
            Console.WriteLine("E-mail:");
            string clientEmail = Console.ReadLine();
            Console.WriteLine("Sua data de aniversário (DD/MM/AAAA):");
            DateTime clientBirth = DateTime.Parse(Console.ReadLine());
        }
    }
}
