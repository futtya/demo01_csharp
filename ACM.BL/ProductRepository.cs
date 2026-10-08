namespace CMS.BusinessLayer
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.Description = "Assorted Size Set of 4 Yellow Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}