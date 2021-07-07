using System;

namespace ShopElectronic.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopElecttronicDbContext Init();
    }
}