using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using SpecFlow.Internal.Json;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using web_services_ielectric.Resources;
using Xunit;

namespace web_services_ielectric.Tests.Report
{
    [Binding]
    public class ReportServiceTest: WebApplicationFactory<Startup>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private HttpClient _client;
        private Uri _baseUri;
        private Task<HttpResponseMessage> Response { get; set; }
        private ReportResource Report { get; set; }
        private TechnicianResource Technician { get; set; }
     
        public ReportServiceTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Given(@"The Endpoint https://localhost:(.*)/api/v(.*)/reports is available")]
        public void GivenTheEndpointHttpsLocalhostApiVReportsIsAvailable(int port, int version)
        {
            _baseUri = new Uri($"https://localhost:{port}/api/v{version}/reports");
            _client = _factory.CreateClient(new WebApplicationFactoryClientOptions { BaseAddress = _baseUri });
        }
        [Given(@"A Technician is already stored ")]
        public async void GivenATechnicianIsAlreadyStored(Table existingTechnicianResource)
        {
            var technicianUri = new Uri($"https://localhost:44346/api/v1/technician");
            var resource = existingTechnicianResource.CreateSet<SaveTechnicianResource>().First();
            var content = new StringContent(resource.ToJson(), Encoding.UTF8, MediaTypeNames.Application.Json);
            var technicianResponse = _client.PostAsync(technicianUri, content);
            var technicianResponseData = await technicianResponse.Result.Content.ReadAsStringAsync();
            var existingTechnician = JsonConvert.DeserializeObject<TechnicianResource>(technicianResponseData);
            Technician = existingTechnician;
        }


        [When(@"A Post Request is sent to Report")]
        public void WhenAPostRequestIsSentToReport(Table saveReportResource)
        {
            var resource = saveReportResource.CreateSet<SaveReportResource>().First();
            var content = new StringContent(resource.ToJson(), Encoding.UTF8, "application/json");
            Response = _client.PostAsync(_baseUri, content);
        }

        [Then(@"A Response with Status (.*) is received")]
        public void ThenAResponseWithStatusIsReceivedInReport(int expectedStatus)
        {
            var expectedStatusCode = ((HttpStatusCode)expectedStatus).ToString();
            var actualStatusCode = Response.Result.StatusCode.ToString();
            Assert.Equal(expectedStatusCode,actualStatusCode);
           
        }
        [Then(@"A Report Resource is included in Response Body")]
        public async void ThenAReportResourceIsIncludedInResponseBody(Table expectedReportResource)
        {
            var expectedResource = expectedReportResource.CreateSet<ReportResource>().First();
            var responseData = await Response.Result.Content.ReadAsStringAsync();
            var resource = JsonConvert.DeserializeObject<ReportResource>(responseData);
            expectedResource.Id = resource.Id;
            var jsonExpectedResource = expectedResource.ToJson();
            var jsonActualResource = resource.ToJson();
            Assert.Equal(jsonExpectedResource, jsonActualResource);
        }

        [Then(@"A message of (.*) is included in Response Body")]
        public async void ThenAMessageOfIsIncludedInResponseBody(string expectedMessage)
        {
            var actualMessage = await Response.Result.Content.ReadAsStringAsync();
            var jsonExpectedMessage = expectedMessage.ToJson();
            var jsonActualMessage = actualMessage.ToJson();
            Assert.Equal(jsonExpectedMessage, jsonActualMessage);
        }
    }
}