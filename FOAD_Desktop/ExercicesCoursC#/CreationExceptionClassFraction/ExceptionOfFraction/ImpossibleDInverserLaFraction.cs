using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleAppCreationDUneException.ExceptionOfFraction
{
    class ImpossibleDInverserLaFraction : System.Exception
    {
        public ImpossibleDInverserLaFraction() : base()
            {
            this.HelpLink = "https://docs.microsoft.com";
            this.Source = "ImpossibleDInverserLaFractionException_Class_Samples";
        }

        public ImpossibleDInverserLaFraction(string message) : base(message)
        {
        }

        public ImpossibleDInverserLaFraction(string message, System.Exception inner) : base(message, inner)
        {
        }
    }
}