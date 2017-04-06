using RestSharp;
using RestRequest = RestSharp.RestRequest;


namespace Redirects
{
    class Request
    {
        public IRestRequest RestRequest = new RestRequest();
        public Request(string url, Method method)
        {
            RestRequest.JsonSerializer = new RestSharp.Serializers.JsonSerializer();
        }
    }
}
