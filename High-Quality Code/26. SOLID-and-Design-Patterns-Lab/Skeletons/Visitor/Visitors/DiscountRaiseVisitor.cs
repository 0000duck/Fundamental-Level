namespace CustomerService.Visitors
{
    using Models;

    public class DiscountRaiseVisitor : IVisitor
    {
        public void Visit(Customer customer)
        {
            customer.Discount += 5;
        }
    }
}