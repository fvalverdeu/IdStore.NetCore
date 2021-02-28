using IdStore.NetCore.Application.Interfaces.Repositories;

namespace IdStore.NetCore.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(
            IProductRepository productRepository
        )
        {
            Products = productRepository;
        }

        public IProductRepository Products { get; }
    }
}
