using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCreationDUneException.ExceptionOfFraction
{
    public class ImpossibleEvaluationOfFraction:Exception
    {
        public ImpossibleEvaluationOfFraction() : base()
        {
            this.HelpLink = "https://docs.microsoft.com";
            this.Source = "InvalidFractionDenominateurException_Class_Samples";
        }
        public ImpossibleEvaluationOfFraction(string message) : base(message)
        {
            this.HelpLink = "https://docs.microsoft.com";
            this.Source = "InvalidFractionDenominateurException_Class_Samples";
        }
        public ImpossibleEvaluationOfFraction(string message, System.Exception inner) : base(message, inner)
        {
            this.HelpLink = "https://docs.microsoft.com";
            this.Source = "InvalidFractionDenominateurException_Class_Samples";
        }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected ImpossibleEvaluationOfFraction(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
