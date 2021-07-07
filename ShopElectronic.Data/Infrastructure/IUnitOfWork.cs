namespace ShopElectronic.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}