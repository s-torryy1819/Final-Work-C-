namespace final_project.src.main.online_shop
{
    public class ShoppingBasket
    {
        List<Product> shoppingBasket = new List<Product>();
        public void addProduct(Product product1)
        {
            shoppingBasket.Add(product1);
            Console.WriteLine("Product : " + product1.NameOfProduct + " was added to your Shopping Basket");
        }
        public void showShoppingBasket()
        {
            if (shoppingBasket.Count == 0)
            {
                Console.WriteLine("\nShopping Basket is empty...");
            }
            else
            {
                Console.WriteLine("\nShopping Basket :");
                for (int i = 0; i < shoppingBasket.Count; i++)
                {
                    shoppingBasket[i].showProduct();
                }
            }
        }
        public List<Product> getShoppingBasket()
        {
            return shoppingBasket;
        }
        public void clearBasket()
        {
            shoppingBasket.Clear();
        }
    }
}