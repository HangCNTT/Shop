using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Infrastructure
{
    // Lớp dùng để Hủy một đối tượng khi không dùng đến
    public class Disposeable : IDisposable
    {
        private bool isDisposed;
        ~Disposeable()
        {
            Dispose(false);
        }
        //GC lấy lại vùng nhớ
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if(!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        protected virtual  void DisposeCore()
        {
            
        }
    }
}
