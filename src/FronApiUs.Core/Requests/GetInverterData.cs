using FronApiUs.Core.Contracts;
using FronApiUs.Core.Endpoints;
using FronApiUs.Core.Extensions;
using FronApiUs.Core.Models;
using FronApiUs.Core.Parameters;
using MediatR;

namespace FronApiUs.Core.Requests;

public class GetInverterData : IFronApiUsRequest, IRequest<List<InverterData>>
{
    public GetInverterData()
    {
        var parameters = new InverterDataParameters();
        Endpoint = new InverterDataEndpoint(parameters);
    }

    public IFronApiUsEndpoint<IFronApiUsParameters> Endpoint { get; }
}

public class GetInverterDataHandler : IRequestHandler<GetInverterData, List<InverterData>>
{
    private readonly IFronApiUsClient _fronApiUsClient;

    public GetInverterDataHandler(IFronApiUsClient fronApiUsClient)
    {
        _fronApiUsClient = fronApiUsClient;
    }

    public async Task<List<InverterData>> Handle(GetInverterData request, CancellationToken token)
    {
        var result = await _fronApiUsClient.Get<SystemInverterData>(request, token);
        if (result == null)
            return new List<InverterData>();

        var inverterData = new List<InverterData>();

        foreach (var key in result.Body.Data.PowerAc.Values.Keys)
        {
            if (string.IsNullOrWhiteSpace(key) || int.TryParse(key, out var id) == false)
                continue;

            var data = new InverterData
            {
                Id = id,
                PowerAc = result.Body.Data.PowerAc.ExtractQuantity(key),
                EnergyToday = result.Body.Data.EnergyToday.ExtractQuantity(key),
                EnergyThisYear = result.Body.Data.EnergyThisYear.ExtractQuantity(key),
                EnergyOverall = result.Body.Data.EnergyOverall.ExtractQuantity(key),
            };

            inverterData.Add(data);
        }

        return inverterData;
    }
}