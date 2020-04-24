using Autofac;
using System;

namespace Bridge
{
    class Program
    {

        static void Main(string[] args)
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<VectorRender>().As<IRender>()
                .SingleInstance();

            cb.Register((c, p) =>
                new Cirlcle(c.Resolve<IRender>(), p.Positional<float>(0)));

            using var c = cb.Build();
            var circle = c.Resolve<Cirlcle>(
                new PositionalParameter(0, 5.0f));

            //IRender render = new RasterRenderer();
            //var circle = new Cirlcle(render, 5);

            //circle.Draw();
            //circle.Resize(2);
            //circle.Draw();
        }
    }
}
