using Car1.Data;
using Car1.Data.Migrations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Car1.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    public List<Brand> GetBrands()
    {
        using (var context = new ApplicationDbContext())
        {
            return context.Brands.ToList();
        }
    }
    var brands = GetBrands();
    var brandSelectList = new SelectList(brands, "Id", "Name");
    ViewBag.BrandSelectList = brandSelectList;

}
