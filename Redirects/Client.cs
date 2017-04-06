using RestSharp;

namespace Redirects
{
    public class ClientRequest
    {
        public IRestClient Client = new RestClient();
        public IRestRequest Request = new RestRequest();
        public string Url;

        public ClientRequest()
        {
            Request.AddHeader("Accept", "application/json");
        }

        public IRestRequest Get(string url)
        {
            Request.Resource = url;
            Request.Method = Method.GET;
            return Request;
        }

        
    }
}
