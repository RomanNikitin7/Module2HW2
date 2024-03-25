using Module2HW2.Entities;
using Module2HW2.Repositories;
using Module2HW2.Services;

namespace Module2HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productService = new ProductService(new ProductRepository());
            var products = productService.Get();
            PrintProducts(products);

            var cart = new Cart() { Id = 1 };

            var cartService = new CartService(new CartRepository());
            cart = cartService.AddProduct(cart.Id, products[0]);
            cart = cartService.AddProduct(cart.Id, products[1]);

            var orderService = new OrderService(new OrderRepository());
            var order = orderService.Create(cart);
            PrintOrder(order);
        }
        private static void PrintProducts(Product[] products)
        {
            Console.WriteLine("All available products:");
            foreach (var item in products)
            {
                Console.WriteLine(item.Name + ": " + item.Price + "$");
            }

            Console.WriteLine();
        }

        private static void PrintOrder(Order order)
        {
            Console.WriteLine("Order ID: " + order.Id);
            int i = 1;
            foreach (var item in order.Items)
            {
                Console.WriteLine(item.Name + ": " + item.Price + "$");
                i++;
            }
            Console.WriteLine("Total: " + order.TotalPrice + "$");
        }
    }
}
