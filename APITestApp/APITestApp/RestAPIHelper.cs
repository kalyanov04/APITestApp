using RestSharp;

namespace APITestApp
{
    public static class RestApiHelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static string baseURL = @"http:\\localhost:3000";

        public static RestClient SetURL(string endpoint)
        {
            var url = baseURL + endpoint;
            return client = new RestClient(url);
        }
        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            return restRequest;
        }
        public static RestRequest CreateRequest(string id)
        {
            restRequest = new RestRequest(id, Method.GET);
            return restRequest;
        }
        public static RestRequest CreateRequestWithParameters(string userID)
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddQueryParameter("userId", userID);
            return restRequest;
        }
        public static RestRequest CreateRequestWithParameters(User.UserInfo user)
        {
            restRequest = new RestRequest(Method.POST);
            restRequest.AddParameter("id", user.Id);
            restRequest.AddParameter("name", user.Name);
            restRequest.AddParameter("username", user.Username);
            restRequest.AddParameter("email", user.Email);
            restRequest.AddJsonBody(user.Address);
            restRequest.AddParameter("phone", user.Phone);
            restRequest.AddParameter("website", user.Website);
            restRequest.AddJsonBody(user.Company);
            return restRequest;
        }
        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }
    }
}
