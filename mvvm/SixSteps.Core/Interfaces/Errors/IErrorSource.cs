using System;

namespace SixSteps.Core.Interfaces.Errors
{
    public interface IErrorSource
    {
        event EventHandler<ErrorEventArgs> ErrorReported;
    }
}