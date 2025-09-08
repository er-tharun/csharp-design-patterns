using Proxy.Pattern.Modals;

namespace Proxy.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImage imageProxy = new ImageProxy("hello-world.png");
            imageProxy.Display();
            imageProxy.Display();
        }
    }
}
