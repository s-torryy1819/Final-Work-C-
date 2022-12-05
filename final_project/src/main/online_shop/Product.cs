namespace final_project.src.main.online_shop
{
    public class Product
    {
        private int priceOfProduct;
        private string nameOfProduct;
        private int ID;
        public string NameOfProduct
        {
            get { return this.nameOfProduct; }
            set { this.nameOfProduct = value; }
        }
        public int PriceOfProduct
        {
            get { return this.priceOfProduct; }
            set { this.priceOfProduct = value; }
        }
        public Product()
        {
        }
        public Product(int ID, string nameOfProduct, int priceOfProduct)
        {
            this.nameOfProduct = nameOfProduct;
            this.priceOfProduct = priceOfProduct;
            this.ID = ID;
        }
        public void showProduct()
        {
            Console.WriteLine("ID : " + ID + " Product : " + nameOfProduct + " Price : " + priceOfProduct + "$");
        }
    }
}