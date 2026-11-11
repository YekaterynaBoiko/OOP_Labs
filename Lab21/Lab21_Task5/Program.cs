namespace Lab21_Task5
{
    public class Program
    {
        public void AddNewProduct(Basket shop)
        {
            Console.WriteLine("Введіть назву продукту який хочете додати: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введіть ціну товару: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Опис товару(кг, г, пляшка і т.д): ");
            string description = Console.ReadLine();
            Console.WriteLine("Кількість товару: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            shop.AddProduct(new Product
            {
                Name = name,
                Price = price,
                Description = description,
                Amount = amount
            });
            Console.WriteLine("Товар успішно додано");
        }
        public void AddProductToBasket(Basket shop, Basket basket)
        {
            Console.WriteLine("Введіть назву продукту для пошуку: ");
            string name = Console.ReadLine();
            Product found = shop[name]; // додано індексатор для 8 так само
            if (found != null) basket.AddProduct(new Product 
            {
                Name = found.Name, 
                Price = found.Price, 
                Description = found.Description,
                Amount = found.Amount 
            });
            else Console.WriteLine("Продукт не знайдено");
        }

        public void RemoveProduct(Basket basket)
        {
            Console.WriteLine("Введіть назву продукту для видалення: ");
            string name = Console.ReadLine();
            basket.RemoveProductByName(name);
        }

        public void ShowBasket(Basket basket)
        {
            if (basket.Count == 0) Console.WriteLine("Кошик поржній");
            else { basket.PrintShoppingInfo(); }
        }

        static void Main(string[] args)
        {
            Basket shop = new Basket();
            Basket basket = new Basket();
            Program program = new Program();

            shop.AddProduct(new Product {
                Name = "Томат", 
                Price = 20.40, 
                Description = "кг", 
                Amount = 1.0
            });
            shop.AddProduct(new Product { Name = "Коньяк", Price = 180.30, Description = "пляшка", Amount = 1.0 });
            shop.AddProduct(new Product { Name = "Торт Наполеон", Price = 219.85, Description = "г", Amount = 1.0 });
            shop.AddProduct(new Product { Name = "Молоко", Price = 48.50, Description = "л", Amount = 1.0 });

            Console.WriteLine("Доступні довари в магазині: ");
            shop.PrintShoppingInfo();

            while (true)
            {
                Console.WriteLine("\n1 Додати товар \n2 Видалити товар \n3 Показати кошик \n4 Додати новий продукт до магазину \n0 Вийти");
                Console.WriteLine();
                Console.WriteLine("Введіть значення від 0 до 4");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        program.AddProductToBasket(shop, basket); break;
                    case "2":
                        program.RemoveProduct(basket); break;
                    case "3":
                        program.ShowBasket(basket); break;
                    case "4":
                        program.AddNewProduct(shop); break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Помилка користувача"); break;
                }
            }
        }
    }
}
