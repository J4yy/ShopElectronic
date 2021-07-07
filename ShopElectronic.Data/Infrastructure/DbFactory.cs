namespace ShopElectronic.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopElecttronicDbContext     dbContext;

        public ShopElecttronicDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopElecttronicDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}