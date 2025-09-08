using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Pattern.Modals
{
    public class ImageProxy : IImage
    {
        private RealImage _realImage;
        private readonly string _fileName;
        public ImageProxy(string fileName)
        {
            _realImage = null;
            _fileName = fileName;
        }
        public void Display()
        {
            if(_realImage is null)
                _realImage = new RealImage(_fileName);
            _realImage.Display();
        }
    }
}
