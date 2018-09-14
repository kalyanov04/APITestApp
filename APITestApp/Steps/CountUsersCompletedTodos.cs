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
    public sealed class CountUsersCompletedTodos
    {
        [When(@"I call GET method using (.*) and (.*)")]
        public void WhenICallGETMethodUsingAndTrue(string userId, string completed)
        {
            RestApiHelper.CreateGetRequestWithParameters(userId, completed);
        }
        [Then(@"the result must be (.*)")]
        public void ThenTheResultMustBe(string quantity)
        {
            var response = RestApiHelper.GetResponse();
            JArray content = JArray.Parse(response.Content);
            Assert.AreEqual(quantity, content.Count.ToString());
        }

    }
}
