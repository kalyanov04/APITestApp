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
        public static RestRequest CreateGetRequest()
        {
            restRequest = new RestRequest(Method.GET);
            return restRequest;
        }
        public static RestRequest CreateGetRequest(string id)
        {
            restRequest = new RestRequest(id, Method.GET);
            return restRequest;
        }
        public static RestRequest CreateGetRequestWithParameters(string userID)
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddQueryParameter("userId", userID);
            return restRequest;
        }
        public static RestRequest CreatePostRequestWithParameters(object obj)
        {
            restRequest = new RestRequest(Method.POST);
            restRequest.AddJsonBody(obj);
            return restRequest;
        }
        public static RestRequest CreateDeleteRequest(string id)
        {
            restRequest = new RestRequest(id, Method.DELETE);
            return restRequest;
        }
        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }
    }
}
