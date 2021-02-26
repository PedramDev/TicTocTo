using System;

namespace TicTacToe.Share
{
    public class OperationResult : IEquatable<bool>
    {
        public bool Success { get; private set; }
        public ErrorType ErrorType { get; private set; }
        public string ErrorMessage { get; private set; }

        public static OperationResult BuildSuccess()
        {
            return new OperationResult { Success = true };
        }
        public static OperationResult BuildFailure(ErrorType errorType)
        {
            return new OperationResult { Success = false, ErrorType = errorType };
        }
        public static OperationResult BuildFailure(string errorMessage)
        {
            return new OperationResult { Success = false, ErrorMessage = errorMessage };
        }

        internal static OperationResult BuildFailure()
        {
            return new OperationResult { Success = false, ErrorType = ErrorType.Unknown };
        }

        public bool Equals(bool other)
        {
            return Success == other;
        }
        public static implicit operator bool(OperationResult d) => d.Success;
    }
}
