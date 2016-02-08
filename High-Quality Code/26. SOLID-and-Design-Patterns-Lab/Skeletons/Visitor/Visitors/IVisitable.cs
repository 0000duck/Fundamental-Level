namespace CustomerService.Visitors
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}