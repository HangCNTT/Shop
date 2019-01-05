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
    public interface IFooterService
    {
        void Add(Footer footer);
        void Update(Footer footer);
        void Delete(int id);
        IEnumerable<Footer> GetAll();
        Footer GetById(int id);
        void save();
        
    }
    public class FooterService : IFooterService
    {
        IFooterRepository _footerRepository;
        IUnitOfWork _unitOfWork;

        public FooterService(IFooterRepository footerRepository, IUnitOfWork unitOfWork)
        {
            this._footerRepository = footerRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Footer footer)
        {
            _footerRepository.Add(footer);
        }

        public void Delete(int id)
        {
            _footerRepository.Delete(id);
        }

        public IEnumerable<Footer> GetAll()
        {
            return _footerRepository.GetAll();
        }

        public Footer GetById(int id)
        {
            return _footerRepository.GetSingleById(id);
        }

        public void save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Footer footer)
        {
            _footerRepository.Update(footer);
        }
        
    }
}
