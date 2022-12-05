namespace final_project.src.main.online_shop
{
    public class PurchaseHistory
    {
        List<Product> productList = new List<Product>();
        public void addProduct(Product product1)
        {
            productList.Add(product1);
        }
        public void showPurchaseHistory()
        {
            if (productList.Count == 0)
            {
                Console.WriteLine("\nPurchase History is empty...");
            }
            else
            {
                Console.WriteLine("\nPurchase History :");
                for (int i = 0; i < productList.Count; i++)
                {
                    productList[i].showProduct();
                }
            }
        }
    }
}