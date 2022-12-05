namespace final_project.src.main.online_shop
{
    class OnlineShop
    {
        static ProductList productList = new ProductList();
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Cleansing foaming gel", 20);
            Product product2 = new Product(2, "Cleansing Oil", 23);
            Product product3 = new Product(3, "Piling gel", 35);
            Product product4 = new Product(4, "Micellar water", 30);
            Product product5 = new Product(5, "Face cream", 22);
            Product product6 = new Product(6, "Effaclar Duo+", 16);
            Product product7 = new Product(7, "Mosturizer cream", 22);
            Product product8 = new Product(8, "Pure Vitamin C", 44);
            Product product9 = new Product(9, "Ultra Derallergo cream", 22);
            Product product10 = new Product(10, "Ultra cream", 54);
            Product product11 = new Product(11, "BAH SPF 50+", 19);

            productList.addProduct(product1);
            productList.addProduct(product2);
            productList.addProduct(product3);
            productList.addProduct(product4);
            productList.addProduct(product5);
            productList.addProduct(product6);
            productList.addProduct(product7);
            productList.addProduct(product8);
            productList.addProduct(product9);
            productList.addProduct(product10);
            productList.addProduct(product11);
            string userName, password;
            Console.WriteLine("\nSign IN to enter La-Roche-Posay Shop : ");
            Console.WriteLine("\nEnter your name : ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your password : ");
            password = Console.ReadLine();
            User user1 = new User(userName, password, 0);
            Console.Clear();
            Console.Write("Happy to see you, " + userName);
            int value;
            do
            {
                Console.Write("\n\nHere are the actions you can do in La-Roche-Posay Shop : ");
                Console.WriteLine("\n1 - See our products"); // See all items we have in shop.
                Console.WriteLine("2 - See current balance"); // See your current balance - how much money do you have left.
                Console.WriteLine("3 - Change current balance"); // Increase or decrease your current balance.
                Console.WriteLine("4 - See Purchase history"); // See what have you bought.
                Console.WriteLine("5 - See Shopping basket"); // See what have you added to Shopping Basket.
                Console.WriteLine("6 - Proceed to checkout"); // See Shopping Basket and either buy items or no.
                Console.WriteLine("0 - Sign OUT"); // Sing out of your account.
                Console.WriteLine("Please select an option:");
                value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1: productList.showProducts(); productList.buyingOption(user1); break;
                    case 2: showCurrentBalance(user1); break;
                    case 3: changeCurrentBalance(user1); break;
                    case 4: productList.showPurchaseHistory(); break;
                    case 5: productList.showShoppingBasket(); break;
                    case 6: productList.proceedToCheckout(user1); break;
                }
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
                Console.Clear();
            } while (value != 0);
            Console.Write("You are signing out... See you soon, " + userName);
        }
        public static void showCurrentBalance(User user1)
        {
            Console.WriteLine("Your current balance is " + user1.getCurrentBalance() + "$");
        }
        public static void changeCurrentBalance(User user1)
        {
            Console.WriteLine("Your current balance is " + user1.getCurrentBalance() + "$");
            Console.WriteLine("Choose: 1 - if you want to increase balance; 2 - if you want to decrease balance :");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Enter the value you want to add to balance : ");
                int value = Convert.ToInt32(Console.ReadLine());
                user1.increaseCurrentBalance(value);
                Console.WriteLine("Your current balance was increased : " + user1.getCurrentBalance() + "$");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter the value : ");
                int value = Convert.ToInt32(Console.ReadLine());
                int result = user1.decreaseCurrentBalance(value);
                if (result == 1)
                {
                    Console.WriteLine("Balance can not be decreased...");
                }
                else
                {
                    Console.WriteLine("Your current balance was decreased : " + user1.getCurrentBalance() + "$");
                }
            }
            else
            {
                Console.WriteLine("Invalid input...");
            }

        }
    }
}