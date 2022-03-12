using FronApiUs.Core.Models;

namespace FronApiUs.Core.Contracts;

public interface IFronApiUsResponse
{
    Head Head { get; set; }
}