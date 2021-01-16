using System;
using OrdemProdutos.Entities;
using OrdemProdutos.Entities.Enums;

namespace OrdemProdutos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o seu nome:");
            string clientName = Console.ReadLine();
            Console.WriteLine("E-mail:");
            string clientEmail = Console.ReadLine();
            Console.WriteLine("Sua data de nascimento (DD/MM/AAAA):");
            DateTime clientBirth = DateTime.Parse(Console.ReadLine());
            //Parâmetros Client
            Client client = new Client(clientName,clientEmail,clientBirth);

            Console.WriteLine("Digite o status do pedido (Pending, Processing, Shipped , Delivered");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            //Parâmetros Order
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("Digite quantos items você deseja:");
            int quantity = int.Parse(Console.ReadLine());

            for(int i =0; i<quantity; i++) {
                Console.WriteLine("Digite os dados do {0}° item:", i+1);
                Console.WriteLine("Nome do produto: ");
                string nameProduct = Console.ReadLine();
                Console.WriteLine("Preço:");
                double priceProduct = double.Parse(Console.ReadLine());
                //Parâmetros Product
                Product product = new Product(nameProduct,priceProduct);

                Console.WriteLine("Quantidade de produtos:");
                int productQtd = int.Parse(Console.ReadLine());
                          
                //Parâmetros OrderItem
                OrderItem orderItem = new OrderItem(productQtd,priceProduct,product);
                orderItem.subTotal(priceProduct);
                order.addItem(orderItem);
                
                
            }
            Console.WriteLine(client);
            Console.WriteLine(status);
        }
    }
}
