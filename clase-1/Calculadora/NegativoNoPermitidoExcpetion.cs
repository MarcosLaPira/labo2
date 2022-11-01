using System.Runtime.Serialization;

namespace BiblioCalculadora
{
    [Serializable]
    public class NegativoNoPermitidoExcpetion : Exception
    {
        public NegativoNoPermitidoExcpetion()
        {
        }

        public NegativoNoPermitidoExcpetion(string? message) : base(message)
        {
        }

        public NegativoNoPermitidoExcpetion(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NegativoNoPermitidoExcpetion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}