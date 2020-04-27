using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.DependencyInjectinDecorator
{
    public class ReportingServiceWithLogging : IReportingService
    {
        private IReportingService decoreded;
        public ReportingServiceWithLogging(IReportingService decorated)
        {
            this.decoreded = decorated;
        }

        public void Report()
        {
            Console.WriteLine("Comencing log...");
            decoreded.Report();
            Console.WriteLine("Ending log...");
        }
    }
}
