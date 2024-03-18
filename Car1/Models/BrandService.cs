using Car1.Data;

namespace Car1.Models
{
    public class BrandService
    {
        private readonly ApplicationDbContext _context;

        public BrandService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }
    }
}
