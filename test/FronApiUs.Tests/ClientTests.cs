using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using FronApiUs.Core;
using FronApiUs.Core.Requests;
using Xunit;

namespace FronApiUs.Tests
{
    public class ClientTests
    {
        private readonly FronApiUsClient _fronApiUsClient;

        public ClientTests()
        {
            var configuration = new FronApiUsConfiguration(IPAddress.Parse(""));
            _fronApiUsClient = new FronApiUsClient(configuration, new HttpClient());
        }

        [Fact]
        public async Task GetCumulationInverterData()
        {
            var request = new GetCumulationInverterData(1);
            var handler = new GetCumulationInverterDataHandler(_fronApiUsClient);

            var result = await handler.Handle(request, default);
            result.Should().NotBeNull();
        }

        [Fact]
        public async Task GetCommonInverterData()
        {
            var request = new GetCommonInverterData(1);
            var handler = new GetCommonInverterDataHandler(_fronApiUsClient);

            var result = await handler.Handle(request, default);
            result.Should().NotBeNull();
        }

        [Fact]
        public async Task GetThreePhaseInverterData()
        {
            var request = new GetThreePhaseInverterData(1);
            var handler = new GetThreePhaseInverterDataHandler(_fronApiUsClient);

            var result = await handler.Handle(request, default);
            result.Should().NotBeNull();
        }

        [Fact]
        public async Task GetMinMaxInverterData()
        {
            var request = new GetMinMaxInverterData(1);
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
}
