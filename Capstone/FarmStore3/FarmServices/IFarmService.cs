using FarmStore3.DAL;
using FarmStore3.DAL.Models;
using FarmStore3.Models;
using System;
using System.Collections.Generic;

namespace FarmStore3.FarmServices
{
    public interface IFarmService
    {
        ProductViewModel GetProducts();
        ProductViewModel AddProduct(ProductViewModel model);
        ProductViewModel UpdateProduce(int id, Products produce);
    }

    public class FarmService : IFarmService
    {
        private readonly IFarmStore _farmStore;

        public FarmService(IFarmStore farmStore)
        {
            _farmStore = farmStore;
        }

        public ProductViewModel GetProducts()
        {
            var dalProducts = _farmStore.SelectAllProduct();
            var products = new List<Products>();

            foreach (var dalProduct in dalProducts)
            {
                var product = new Products();
                product.ProduceName = dalProduct.ProduceName;
                product.ProduceID = dalProduct.ProduceID;
                products.Add(product);
            }
            var ProductViewModel = new ProductViewModel();
            ProductViewModel.Products = products;

            return ProductViewModel;
        }

        public ProductViewModel AddProduct(ProductViewModel model)
        {
            var dalModel = new FarmDALModel();
            dalModel.ProduceName = model.ProduceName;
            _farmStore.AddProduct(dalModel);

            //MAPPING
            var dalProducts = _farmStore.SelectAllProduct();
            var products = new List<Products>();

            foreach (var dalProduct in dalProducts)
            {
                var product = new Products();
                product.ProduceName = dalProduct.ProduceName;
                products.Add(product);
            }

            var ProductViewModel = new ProductViewModel();
            ProductViewModel.Products = products;

            return ProductViewModel;
        }

        public ProductViewModel UpdateProduce(int id, Products produce)
        {
            _farmStore.UpdateProduct(id, produce);
            throw new NotImplementedException();
        }
    }
}
