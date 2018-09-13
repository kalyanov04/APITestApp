using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace APITestApp.Steps
{
    [Binding]
    public sealed class DeleteUser
    {
        [When(@"I call DELETE method using (.*)")]
        public void WhenICallDELETEMethodUsing(string id)
        {
            RestApiHelper.CreateDeleteRequest(id);
        }

    }
}
