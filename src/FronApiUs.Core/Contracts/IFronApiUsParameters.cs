namespace FronApiUs.Core.Contracts;

public interface IFronApiUsParameters
{
}

public class FronApiUsParameters : IFronApiUsParameters
{
    public static FronApiUsParameters Empty()
    {
        return new FronApiUsParameters();
    }
}