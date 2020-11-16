using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCreationDUneException
{
    [Serializable()]
    public class InvalidFractionDenominateurException : System.Exception
    {
        public InvalidFractionDenominateurException() : base() 
        {
            this.HelpLink = "https://docs.microsoft.com";
            this.Source = "InvalidFractionDenominateurException_Class_Samples";
        }
        public InvalidFractionDenominateurException(string message) : base(message) 
        { 
        }
        public InvalidFractionDenominateurException(string message, System.Exception inner) : base(message, inner) 
        { 
        }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected InvalidFractionDenominateurException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
