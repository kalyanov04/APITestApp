using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace APITestApp.Steps
{
    [Binding]
    public sealed class APIResponse
    {
        [Given(@"I have an endpoint (.*)")]
        public void GivenIHaveAnEndpoint(string endPoint)
        {
            RestApiHelper.SetURL(endPoint);
        }
        [When(@"I call GET method of api")]
        public void WhenICallGETMethodOfApi()
        {
            RestApiHelper.CreateGetRequest();
        }
        [Then(@"I get API response")]
        public void ThenIGetAPIResponse()
        {
            var response = RestApiHelper.GetResponse();
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
        }
    }
}
