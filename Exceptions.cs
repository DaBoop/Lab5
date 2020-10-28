using System;
using System.Collections.Generic;
using System.Text;

    namespace System
    {
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
