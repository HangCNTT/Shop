using Shop.Data.Infrastructure;
using Shop.Data.Repositories;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public interface IProductService
    {
        Product Add(Product product);
        void Update(Product product);
        Product Delete(int id);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllByPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Product> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);
        IEnumerable<Product> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow);
        Product GetById(int id);
        void SaveChanges();
    }
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        IUnitOfWork _unitOfWork;
        //constructure 
        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }
        public Product Add(Product product)
        {
            return _productRepository.Add(product);
        }

        public Product Delete(int id)
        {
            return _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll(new string[] { "ProductCategory"});
        }

        public IEnumerable<Product> GetAllByCategoryPaging(int productCategory, int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x => x.Status && x.ProductCategoryID == productCategory, out totalRow, page, pageSize, new string[] { "ProductCategory" });
        }

        public IEnumerable<Product> GetAllByPaging(int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public Product GetById(int id)
        {
            return _productRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
