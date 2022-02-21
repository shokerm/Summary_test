using System.Runtime.Serialization;

namespace Lesson_15
{
    [Serializable]
    internal class FruitException : Exception
    {
        public FruitException()
        {
        }

        public FruitException(string? message) : base(message)
        {
        }

        public FruitException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FruitException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}