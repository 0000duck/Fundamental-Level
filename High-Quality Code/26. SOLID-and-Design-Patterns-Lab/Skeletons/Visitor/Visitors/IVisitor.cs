namespace CustomerService.Visitors
{
    using Models;

    public interface IVisitor
    {
        void Visit(Customer customer);
    }
}