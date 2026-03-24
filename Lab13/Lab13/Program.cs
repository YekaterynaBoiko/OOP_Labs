namespace Lab13
{
    internal class Program //Task1
    {
        public class Product
        {
            public string Name;
            public double price;
            public string Description; //опис
            public double Amount; //кількість

            public Product(string Name,  double price, string Description, double Amount) //
            {
                this.Name = Name;
                this.price = price;
                this.Description = Description;
                this.Amount = Amount;
            }
        }
        public class Basket
        {
            public List<Product> products = new List<Product>();

            public void AddProduct(Product product)
            {
                products.Add(product);
            }

            public void RemoveProductByName(string Name)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Name == Name)
                    {
                        products.RemoveAt(i);
                        return;
                    }
                }
                Console.WriteLine("Продукт не знайдено");
            }

            public double CalcTotal()
            {
                double sumOfProducts = 0.0;
                foreach (var product in products)
                {
                    sumOfProducts += product.price * product.Amount;
                }
                Console.WriteLine($"До сплати: {sumOfProducts}грн");
                return sumOfProducts;
            }

            public Product SearchByName(string Name)
            {
                foreach (var product in products)
                {
                    if (product.Name == Name) return product;
                }
                return null;
            }
            public void PrintShoppingInfo()
            {
                foreach(var product in products)
                {
                    Console.WriteLine($"Назва продукту: {product.Name} \nЦіна: {product.price}грн \nОпис(г, кг, пляшка і т.д): {product.Description} \nКількість: {product.Amount}");
                }
                Console.WriteLine(CalcTotal());
            }

            public void AddNewProduct()
            {
                Console.WriteLine("Введіть назву продукту який хочете додати: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введіть ціну товару: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Опис товару(кг, г, пляшка і т.д): ");
                string description = Console.ReadLine();
                Console.WriteLine("Кількість товару: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                AddProduct(new Product(name, price, description, amount));
                Console.WriteLine("Товар успішно додано");
            }
        }
        
        public void AddProductToBasket(Basket shop, Basket basket)
        {
            Console.WriteLine("Введіть назву продукту для пошуку: ");
            string name = Console.ReadLine();
            Product found = shop.SearchByName(name);
            if (found != null) basket.AddProduct(new Product(found.Name, found.price, found.Description, found.Amount));
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
            if (basket.products.Count == 0) Console.WriteLine("Кошик поржній");
            else { basket.PrintShoppingInfo();}
        }
        static void Main(string[] args)
        {
            Basket shop = new Basket();
            Basket basket = new Basket();
            Program program = new Program();

            shop.AddProduct(new Product("Томат", 20.40, "кг", 1.0));
            shop.AddProduct(new Product("Коньяк", 180.30, "пляшка", 1.0));
            shop.AddProduct(new Product("Торт Наполеон", 219.85, "г", 1.0));
            shop.AddProduct(new Product("Молоко", 48.50, "л", 1.0));

            Console.WriteLine("Доступні довари в магазині: ");
            shop.PrintShoppingInfo();

            while(true)
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
                        shop.AddNewProduct(); break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Помилка користувача"); break;
                }

            }
        }
    }
}

