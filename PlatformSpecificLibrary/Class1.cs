using System;

namespace PlatformSpecificLibrary
{
    public class Class1
    {
        public void Run()
        {
#if LINUX
#error "This library cannot be compiled on Linux."
#else
            Console.WriteLine("This library is running on a supported OS.");
#endif
        }
    }
}
