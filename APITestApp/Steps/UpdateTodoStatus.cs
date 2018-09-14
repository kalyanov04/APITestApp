using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace APITestApp.Steps
{
    [Binding]
    public sealed class UpdateTodoStatus
    {
        [When(@"I call PUT method using (.*) and (.*)")]
        public void WhenICallPOSTMethodUsingAndTrue(string id, string complete)
        {
            RestApiHelper.CreateGetRequest(id);
            var response = RestApiHelper.GetResponse();
            Todos todo = JsonConvert.DeserializeObject<Todos>(response.Content);
            todo.Completed = complete;

            RestApiHelper.CreatePutRequestWithParameters(id, todo);
        }
    }
}
