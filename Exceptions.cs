using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

    namespace System
    {
        [Serializable]
        internal class GiftAction : Exception
        {

        public GiftAction(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        public GiftAction()
            {
            }

            public GiftAction(string message) : base(message)
            {
            }

            public GiftAction(string message, Exception innerException) : base(message, innerException)
            {
            }
        }
    internal class GoodsException : Exception
        {
            public GoodsException()
            {
            }

            public GoodsException(string message) : base(message)
            {
            }

            public GoodsException(string message, Exception innerException) : base(message, innerException)
            {
            }
        }
        internal class NegativeAmountException : GoodsException
        {
            public NegativeAmountException()
            {
            }

            public NegativeAmountException(string message) : base(message)
            {
            }

            public NegativeAmountException(string message, Exception innerException) : base(message, innerException)
            {
            }
        }

        internal class EmptyListException : Exception
        {
            public EmptyListException()
            {
            }

            public EmptyListException(string message) : base(message)
            {
            }

            public EmptyListException(string message, Exception innerException) : base(message, innerException)
            {
            }
        }

}  
