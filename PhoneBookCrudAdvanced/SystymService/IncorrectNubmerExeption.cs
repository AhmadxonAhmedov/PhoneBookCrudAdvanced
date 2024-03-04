using System.Runtime.Serialization;

namespace PhoneBookCrudAdvanced.SystymService
{
    [Serializable]
    internal class IncorrectNubmerExeption : Exception
    {
        public IncorrectNubmerExeption()
        {
        }

        public IncorrectNubmerExeption(string? message) : base(message)
        {
        }

        public IncorrectNubmerExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IncorrectNubmerExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}