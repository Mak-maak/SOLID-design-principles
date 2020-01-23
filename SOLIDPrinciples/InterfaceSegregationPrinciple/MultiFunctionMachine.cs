using System;

namespace InterfaceSegregationPrinciple
{
    class MultiFunctionMachine : IMultiFunctionDevice
    {
        private IPrinter Printer;
        private IScanner Scanner;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            this.Printer = printer ?? throw new ArgumentNullException(paramName: nameof(printer));
            this.Scanner = scanner ?? throw new ArgumentNullException(paramName: nameof(scanner));
        }

        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }
}
