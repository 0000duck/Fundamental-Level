namespace CustomerService.Visitors
{
    using Models;

    public class FreePurchaseVisitor : IVisitor
    {
        public void Visit(Customer customer)
        {
            customer.Purchases.Add(new Purchase("SteamOp", 0.0));
        }
    }
}