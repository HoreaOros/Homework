﻿using System;
using System.Runtime.Serialization;

namespace Operatii_cu_matrici
{
    [Serializable]
    internal class ImpossibleMatrixOperationException : Exception
    {
        public ImpossibleMatrixOperationException()
        {
        }

        public ImpossibleMatrixOperationException(string message) : base(message)
        {
        }

        public ImpossibleMatrixOperationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ImpossibleMatrixOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}