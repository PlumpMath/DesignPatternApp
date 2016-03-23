using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyPattern.Core.Interface;

namespace ProxyPattern.Core.Class
{
    public class ProxyImage : IImage
    {
        private RealImage _realImage;
        private readonly string _fileName;

        public ProxyImage(string fileName)
        {
            this._fileName = fileName;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
            }

            _realImage.Display();
        }
    }
}
