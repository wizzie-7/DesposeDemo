using System;

namespace DesposeDemo
{
    class ResourceManagement : IDisposable
    {
        private bool Disposed = false;
        public ResourceManagement()
        {
            Console.WriteLine("Object is created");
        }
        ~ResourceManagement()
        {
            Console.WriteLine("Destructor called");
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Called From Dispose");
                    //Clear all the managed resources here  
                }
                else
                {
                    //Clear all the unmanaged resources here  
                }
                Disposed = true;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ResourceManagement RM = new ResourceManagement();
            RM.Dispose();
            RM = null;
        }
    }
}
