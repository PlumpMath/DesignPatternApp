using System;
using ProxyPattern.Core.Interface;

namespace ProxyPattern.Core.Class
{
    public class RealImage : IImage
    {
        private readonly string _fileName;

        public RealImage(string fileName)
        {
            this._fileName = fileName;
            LoadFromDisk(this._fileName);
        }

        public void Display()
        {
            Console.WriteLine("Display filename: {0}", _fileName);
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine("Loading file from disk: {0}", fileName);
        }
    }
}