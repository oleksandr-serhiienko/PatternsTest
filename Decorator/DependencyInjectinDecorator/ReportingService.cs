using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.DependencyInjectinDecorator
{
    public class ReportingService : IReportingService
    {
        public void Report()
        {
            Console.WriteLine("Here is your report");
        }
    }
}
