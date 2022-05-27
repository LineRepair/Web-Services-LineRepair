using System;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using SpecFlow.Internal.Json;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using web_services_ielectric.Resources;
using Xunit;

namespace web_services_ielectric.Tests.ApplianceModel
{
    [Binding]
    public class ApplianceModelServiceTestsSteps
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private HttpClient _client;
        private Uri _baseUri;
        private Task<HttpResponseMessage> Response { get; set; }
        private ApplianceBrandResource ApplianceBrand { get; set; }
        private ApplianceModelResource ApplianceModel { get; set; }
        public ApplianceModelServiceTestsSteps(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Given(@"The Endpoint https://localhost:(.*)/api/v(.*)/applianceModel is available")]
        public void GivenTheEndpointHttpsLocalhostApiVApplianceModelIsAvailable(int port, int version)
        {
            _baseUri = new Uri($"https://localhost:{port}/api/v{version}/applianceModel");
            _client = _factory.CreateClient(new WebApplicationFactoryClientOptions {BaseAddress = _baseUri});
        }
        
        [Given(@"A ApplianceBrand is already stored ")]
        public async void GivenAApplianceBrandIsAlreadyStored(Table existingApplianceBrandResource)
        {
            var applianceBrandUri = new Uri($"https://localhost:44346/api/v1/applianceBrand");
            var resource = existingApplianceBrandResource.CreateSet<SaveApplianceBrandResource>().First();
            var content = new StringContent(resource.ToJson(), Encoding.UTF8, MediaTypeNames.Application.Json);
            var applianceBrandResponse = _client.PostAsync(applianceBrandUri, content);
            var applianceBrandResponseData = await applianceBrandResponse.Result.Content.ReadAsStringAsync();
            var existingApplianceBrand = JsonConvert.DeserializeObject<ApplianceBrandResource>(applianceBrandResponseData);
            ApplianceBrand = existingApplianceBrand;
        }

        [When(@"A Post Request is sent to ApplianceModel")]
        public void  WhenAPostRequestIsSentToApplianceModel(Table saveApplianceModelResource)
        {
            var resource = saveApplianceModelResource.CreateSet<SaveApplianceModelResource>().First();
            var content = new StringContent(resource.ToJson(), Encoding.UTF8, "applicarion/json");
            Response = _client.PostAsync(_baseUri, content);
        }

        [Then(@"A Response with Status (.*) is received in ApplianceModel")]
        public void ThenAResponseWithStatusIsReceivedInApplianceModel(int expectedStatus)
        {
            var expectedStatusCode = ((HttpStatusCode)expectedStatus).ToString();
            var actualStatusCode = Response.Result.StatusCode.ToString();
            Assert.Equal(expectedStatusCode,actualStatusCode);
        }
        [Then(@"A ApplianceModel Resource is included in Response Body")]
        public async void ThenAApplianceModelResourceIsIncludedInResponseBody(Table expectedApplianceModelResource)
        {
            var expectedResource = expectedApplianceModelResource.CreateSet<ApplianceModelResource>().First();
            var responseData = await Response.Result.Content.ReadAsStringAsync();
            var resource = JsonConvert.DeserializeObject<ApplianceModelResource>(responseData);
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