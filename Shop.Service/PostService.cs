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
    public interface IPostService
    {
        Post Add(Post post);
        void Update(Post post);
        Post Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllByPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Post> GetAllByCategoryPaging(int categoryId,int page,int pageSize,out int totalRow);
        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        Post GetById(int id);
        void SaveChanges();
    }

    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;
        //constructure 
        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public Post Add(Post post)
        {
           return  _postRepository.Add(post);
        }

        public Post Delete(int id)
        {
           return _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            //lấy ra bao gồm cả bản chứa khóa ngoại
            return _postRepository.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status && x.PostCategoryID == categoryId, out totalRow, page, pageSize, new string[] {"PostCategory"});
        }

        public IEnumerable<Post> GetAllByPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetAllByTag(tag, page, pageSize,out totalRow);
        }

        public Post GetById(int id)
        {
           return _postRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}    
