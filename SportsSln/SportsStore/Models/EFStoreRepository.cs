
namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDBContext context;

        public EFStoreRepository(StoreDBContext context)
        {
            this.context = context;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
