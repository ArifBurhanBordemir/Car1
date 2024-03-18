using Car1.Data;
using Car1.Data.Migrations;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing;

namespace Car1.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string CarPlate { get; set; }
        public int Km { get; set; }
        public TimeSpan Model { get; set; }
        public string Color { get; set; }
        public string GearType { get; set; }
        public string Brand { get; set; }

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
