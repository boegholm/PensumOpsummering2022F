
using System.Runtime.Serialization;

namespace Eksamen
{
    public class EmailValidationException : Exception
    {
        public EmailValidationException()
        {
        }

        public EmailValidationException(string? message) : base(message)
        {
        }

        public EmailValidationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmailValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
