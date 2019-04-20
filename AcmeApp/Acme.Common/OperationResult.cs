namespace Acme.Common
{
    /// <summary>
    /// Provides a success flag and message 
    /// useful as a method return type.
    /// </summary>
    public class OperationResult<TResult, TMessage>
    {
        public OperationResult()
        {
        }

        public OperationResult(TResult result, TMessage message) : this()
        {
            this.Result = result;
            this.Message = message;
        }

        public TResult Result { get; set; }
        public TMessage Message { get; set; }
    }

    /* public class OperationResultDecimal
    {
        public OperationResultDecimal()
        {
        }

        public OperationResultDecimal(decimal result, string message) : this()
        {
            this.Result = result;
            this.Message = message;
        }

        public decimal Result { get; set; }
        public string Message { get; set; }
    } */

}
