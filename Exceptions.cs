using System;
using System.Collections.Generic;
using System.Text;

    namespace System
    {
        [Serializable]
        internal class NegativeAmount : Exception
        {
            public NegativeAmount()
            {
            }

            public NegativeAmount(string message) : base(message)
            {
            }

            public NegativeAmount(string message, Exception innerException) : base(message, innerException)
            {
            }
        }
    }
