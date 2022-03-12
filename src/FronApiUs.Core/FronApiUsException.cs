using FronApiUs.Core.Models;

namespace FronApiUs.Core;

public class FronApiUsException : Exception
{
    public FronApiUsException()
    {
    }

    public FronApiUsException(Status status) : base(status.ExceptionMessage)
    {
    }

    public FronApiUsException(Status status, Exception exception) : base(status.ExceptionMessage, exception)
    {
    }
}