using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace APITestApp.Steps
{
    [Binding]
    public sealed class AddNewUser
    {
        [When(@"I call POST method with body (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*)")]
        public void WhenICallPOSTMethodWithBody(int id, string name, string username, string email, string street,
            string suite, string city, int zipcode, double lat, double lng, string phone, string website, string cname, string catchPhrase, string bs)
        {
            User.UserInfo newUser = new User.UserInfo()
                .SetId(id)
                .SetName(name)
                .SetUsername(username)
                .SetEmail(email)
                .SetAddress(new User.Address(street, suite, city, zipcode, new User.Geo(lat, lng)))
                .SetPhone(phone)
                .SetWebsite(website)
                .SetCompany(new User.Company(cname, catchPhrase, bs));
            RestApiHelper.CreateRequestWithParameters(newUser);
        }
        [Then(@"response status is ok and user added")]
        public void ThenResponseStatusIsOkAndUserAdded()
        {
            var response = RestApiHelper.GetResponse();
            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
        }

    }
}
