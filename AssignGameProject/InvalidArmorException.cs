using System.Runtime.Serialization;

namespace AssignGameProject
{
    [Serializable]
    internal class InvalidArmorException : Exception
    {
        public InvalidArmorException()
        {
        }

        public InvalidArmorException(string? message) : base(message)
        {
        }

        public InvalidArmorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidArmorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}