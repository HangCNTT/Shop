  using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Infrastructure
{
    public interface IRepository<T> where T: class
    {
        // thêm mới đối tượng
        T Add(T entity);

        //sửa
        void Update(T entity);

        //Xóa
        T Delete(T entity);
        T Delete(int id);
        //Xoa nhieu
        void DeleteMulti(Expression<Func<T, bool>> where);

        //lấy đối tượng theo ID
        T GetSingleById(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T, bool>> predicate);

    }
}
