using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace APITestApp.Steps
{
    [Binding]
    public sealed class GetUserInfo
    {
        [When(@"I call GET method of api to get user info using (.*)")]
        public void WhenICallGETMethodOfApiToGetUserInfoUsing(string id)
        {
            RestApiHelper.CreateRequest(id);
        }
        [Then(@"I compaare user information to (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*)")]
        public void ThenICompaareUserInformationToChelseyDietrich(int id, string name, string username, string email, string street, 
            string suite, string city, int zipcode, double lat, double lng, string phone, string website, string cname, string catchPhrase, string bs)
        {
            User.UserInfo userInfo = new User.UserInfo()
                .SetId(id)
                .SetName(name)
                .SetUsername(username)
                .SetEmail(email)
                .SetAddress(new User.Address(street, suite, city, zipcode, new User.Geo(lat, lng)))
                .SetPhone(phone)
                .SetWebsite(website)
                .SetCompany(new User.Company(cname, catchPhrase, bs));
            var response = RestApiHelper.GetResponse();
            string expected = JsonConvert.SerializeObject(userInfo);
            User.UserInfo info = JsonConvert.DeserializeObject<User.UserInfo>(response.Content);
            string actual = JsonConvert.SerializeObject(info);
            Assert.AreEqual(expected, actual);
        }
    }
}
