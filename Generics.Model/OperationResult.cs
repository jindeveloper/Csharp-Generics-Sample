using System.Collections.Generic;

namespace Generics.Model
{
    public class OperationResult<TResult> where TResult : new()
    {
        public List<TResult> Result { get; set; }

        public bool Success { get; set; }

        public string ErrorMessage { get; set; }
    }


    public class TransactionResult<T> 
    {
        public List<T> Result { get; set; }

        public bool Success { get; set; }

        public string ErrorMessage { get; set; }
    }
}
