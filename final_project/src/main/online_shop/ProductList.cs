namespace final_project.src.main.online_shop
{
    public class ProductList
    {
        List<Product> productList = new List<Product>();
        PurchaseHistory purchaseHistory = new PurchaseHistory();
        ShoppingBasket shoppingBasket = new ShoppingBasket();
        List<Product> shoppingBasketList = new List<Product>();
        public void addProduct(Product product1)
        {
            productList.Add(product1);
        }
        public void showPurchaseHistory()
        {
            purchaseHistory.showPurchaseHistory();
        }
        public void showShoppingBasket()
        {
            shoppingBasket.showShoppingBasket();
        }

        public void showProducts()
        {
            productList[0].showProduct();
            productList[1].showProduct();
            productList[2].showProduct();
            productList[3].showProduct();
            productList[4].showProduct();
            productList[5].showProduct();
            productList[6].showProduct();
            productList[7].showProduct();
            productList[8].showProduct();
            productList[9].showProduct();
            productList[10].showProduct();
        }
        public void buyingOption(User user)
        {
            Console.WriteLine("\nIf you want to BUY NOW any item, write BUY");
            Console.WriteLine("If you want to ADD ITEM to basket, write ADD");
            Console.WriteLine("Else - write NO");
            string choice = Console.ReadLine();
            if (choice == "BUY")
            {
                Console.WriteLine("What do you want to BUY NOW? Write ID of item : ");
                int itemID = Convert.ToInt32(Console.ReadLine());
                if (itemID < 1 || itemID > 11) Console.WriteLine("Invalid ID...");
                else
                {
                    switch (itemID)
                    {
                        case 1: buyProduct(productList[0], user); break;
                        case 2: buyProduct(productList[1], user); break;
                        case 3: buyProduct(productList[2], user); break;
                        case 4: buyProduct(productList[3], user); break;
                        case 5: buyProduct(productList[4], user); break;
                        case 6: buyProduct(productList[5], user); break;
                        case 7: buyProduct(productList[6], user); break;
                        case 8: buyProduct(productList[7], user); break;
                        case 9: buyProduct(productList[8], user); break;
                        case 10: buyProduct(productList[9], user); break;
                        case 11: buyProduct(productList[10], user); break;
                    }
                    shoppingBasket.clearBasket();
                }
            }
            else if (choice == "ADD")
            {
                Console.WriteLine("What do you want to ADD TO BASKET? Write ID of item : ");
                int itemID = Convert.ToInt32(Console.ReadLine());
                if (itemID < 1 || itemID > 11) Console.WriteLine("Invalid ID...");
                else
                {
                    switch (itemID)
                    {
                        case 1: addProductToBasket(productList[0], user); break;
                        case 2: addProductToBasket(productList[1], user); break;
                        case 3: addProductToBasket(productList[2], user); break;
                        case 4: addProductToBasket(productList[3], user); break;
                        case 5: addProductToBasket(productList[4], user); break;
                        case 6: addProductToBasket(productList[5], user); break;
                        case 7: addProductToBasket(productList[6], user); break;
                        case 8: addProductToBasket(productList[7], user); break;
                        case 9: addProductToBasket(productList[8], user); break;
                        case 10: addProductToBasket(productList[9], user); break;
                        case 11: addProductToBasket(productList[10], user); break;
                    }
                }
            }
            else if (choice != "NO" && choice != "BUY" && choice != "ADD")
            {
                Console.WriteLine("Invalid choice...");
            }
        }
        public void proceedToCheckout(User user)
        {
            showShoppingBasket();
            if (shoppingBasket.getShoppingBasket().Count == 0)
            {
                return;
            }
            Console.WriteLine("\nDo you want to BUY ITEMS from your Shopping Basket?");
            Console.WriteLine("If yes - write YES, if no - write NO");
            string choice = Console.ReadLine();
            if (choice == "YES")
            {
                shoppingBasketList = shoppingBasket.getShoppingBasket();
                int wholePrice = 0;
                for (int i = 0; i < shoppingBasketList.Count; i++)
                {
                    wholePrice += shoppingBasketList[i].PriceOfProduct;
                }
                Console.WriteLine("\nWhole sum of your order : " + wholePrice);
                if (user.decreaseCurrentBalance(wholePrice) == 1)
                {
                    Console.WriteLine("Your don´t have enough money to buy these items...");
                }
                else if (user.decreaseCurrentBalance(wholePrice) == 0)
                {
                    Console.WriteLine("\nCongratulations!!! Operation successful!");
                    Console.WriteLine("Your Current Balance is " + user.getCurrentBalance() + "$");
                    Console.WriteLine("\nYou bought : ");
                    for (int i = 0; i < shoppingBasketList.Count; i++)
                    {
                        shoppingBasketList[i].showProduct();
                        buyItemFromBasket(shoppingBasketList[i], user);
                    }
                    shoppingBasket.clearBasket();
                }
            }
            else if (choice != "NO" && choice != "YES")
            {
                Console.WriteLine("Invalid choice...");
            }
        }
        public void addProductToBasket(Product product, User user)
        {
            shoppingBasket.addProduct(product);
        }
        public void buyProduct(Product product, User user)
        {
            int canBuy = user.decreaseCurrentBalance(product.PriceOfProduct);
            if (canBuy == 1)
            {
                Console.WriteLine("You can not buy this item...");
            }
            else if (canBuy == 0)
            {
                purchaseHistory.addProduct(product);
                Console.WriteLine("Congratulations!!! You bought " + product.NameOfProduct);
                Console.WriteLine("Your Current Balance is " + user.getCurrentBalance() + "$");
            }
        }
        public void buyItemFromBasket(Product product, User user)
        {
            purchaseHistory.addProduct(product);
        }

    }
}