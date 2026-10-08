namespace CMS.BusinessLayer
{
    public class OrderItemRepository
    {
        public OrderItem Retrieve(int orderItemId)
        {
            OrderItem orderItem = new OrderItem(orderItemId);
            return orderItem;
        }

        public bool Save(OrderItem orderItem)
        {
            return true;
        }
    }
}