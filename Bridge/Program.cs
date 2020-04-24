using System;

namespace Bridge
{
    class Program
    {

        static void Main(string[] args)
        {
            IRender render = new RasterRenderer();
            var circle = new Cirlcle(render, 5);

            circle.Draw();
            circle.Resize(2);
            circle.Draw();
        }
    }
}
