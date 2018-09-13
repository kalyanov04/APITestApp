using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace APITestApp.Steps
{
    [Binding]
    public sealed class GetUsersPosts
    {
        [Given(@"I have endpoint (.*)")]
        public void GivenIHaveEndpoint(string endPoint)
        {
            RestApiHelper.SetURL(endPoint);
        }
        [When(@"I call GET method of api to get users posts using (.*)")]
        public void WhenICallGETMethodOfApiToGetUsersPostsUsing(string userId)
        {
            RestApiHelper.CreateGetRequestWithParameters(userId);
        }
        [Then(@"I get (.*) posts")]
        public void ThenIGetAPIResponse(string postQuantity)
        {
            var response = RestApiHelper.GetResponse();
            JArray content = JArray.Parse(response.Content);
            Assert.AreEqual(postQuantity, content.Count.ToString());
        }
    }
}
