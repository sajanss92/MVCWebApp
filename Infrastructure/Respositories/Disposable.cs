using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Respositories
{
    public class Disposable : IDisposable
    {
        private bool m_IsDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!m_IsDisposed && disposing)
            {
                DisposeCore();
            }

            m_IsDisposed = true;
        }

        protected virtual void DisposeCore()
        {
        }
    }
}
