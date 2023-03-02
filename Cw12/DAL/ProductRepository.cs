using Cw12.Models;
using Cw12.Views.ViewModel;

namespace Cw12.DAL
{
    public class ProductRepository
    {
        public void AddProduct(ProducViewModel product)
        {
            Product objproducts = new Product()
            {
                Id = DataStorage.Products.Count() ==0 ? 1 : DataStorage.Products.Last().Id + 1,
                Name = product.Name,
                Color = product.Color,
                Code = product.Code,
                BrandEnum = product.BrandEnum,
                Model = product.Model
            };
            DataStorage.Products.Add(objproducts);
        }
        public List<ProducViewModel> GetAllProduct()
        {
            var product = DataStorage.Products;

            var result = product.Select(x => new ProducViewModel()
            {
                
                    Name =x.Name,
                    Color=x.Color,
                    Code=x.Code,
                    BrandEnum=x.BrandEnum,
                    Model=x.Model
                    

            });
            return result.ToList();

        }
    }
}
