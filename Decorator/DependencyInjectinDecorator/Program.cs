using Autofac;
using Decorator.DependencyInjectinDecorator;
using Decorator.StaticDecorator;
using System;

namespace Decorator.NEE
{
    class Program
    {

        static void Main(string[] args)
        {
            var b = new ContainerBuilder();
            b.RegisterType<ReportingService>().Named<IReportingService>("reporting");
            b.RegisterDecorator<IReportingService>((context, service) => new ReportingServiceWithLogging(service), "reporting");

            using (var c = b.Build())
            {
                var r = c.Resolve<IReportingService>();
                r.Report();
            }


        }
    }
}
