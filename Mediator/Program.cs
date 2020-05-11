using Autofac;
using System;
using MediatR;
using Mediator.NewFolder;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MediatR.Mediator>()
                .As<IMediator>().InstancePerLifetimeScope();

            builder.Register<ServiceFactory>(ctx
                =>
            {
                var c = ctx.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            builder.RegisterAssemblyTypes(typeof(Program).Assembly);

            var container = builder.Build();
            var mediator = container.Resolve<IMediator>();
            var response = await mediator.Send(new PingCommand());
            Console.WriteLine(response.TimeStamp);
        }
    }
}
