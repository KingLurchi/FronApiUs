using System.Threading.Tasks;
using FluentAssertions;
using FronApiUs.Core.Contracts;
using FronApiUs.Core.Requests;
using Xunit;

namespace FronApiUs.Tests;

public class InverterDataTests
{
    private const int DeviceId = 1;
    private readonly IFronApiUsClient _fronApiUsClient = new MockFronApiUsClient();

    [Fact]
    public async Task GetCumulationInverterData()
    {
        var request = new GetCumulationInverterData(DeviceId);
        var handler = new GetCumulationInverterDataHandler(_fronApiUsClient);

        var result = await handler.Handle(request, default);
        result.Should().NotBeNull();
    }

    [Fact]
    public async Task GetCommonInverterData()
    {
        var request = new GetCommonInverterData(DeviceId);
        var handler = new GetCommonInverterDataHandler(_fronApiUsClient);

        var result = await handler.Handle(request, default);
        result.Should().NotBeNull();
    }

    [Fact]
    public async Task GetThreePhaseInverterData()
    {
        var request = new GetThreePhaseInverterData(DeviceId);
        var handler = new GetThreePhaseInverterDataHandler(_fronApiUsClient);

        var result = await handler.Handle(request, default);
        result.Should().NotBeNull();
    }

    [Fact]
    public async Task GetMinMaxInverterData()
    {
        var request = new GetMinMaxInverterData(DeviceId);
        var handler = new GetMinMaxInverterDataHandler(_fronApiUsClient);

        var result = await handler.Handle(request, default);
        result.Should().NotBeNull();
    }

    [Fact]
    public async Task GetInverterData()
    {
        var request = new GetInverterData();
        var handler = new GetInverterDataHandler(_fronApiUsClient);

        var result = await handler.Handle(request, default);
        result.Should().NotBeNull();
    }
}