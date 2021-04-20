using APITesting.Model.JsonModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITesting.RestGetEndPoint
{
    [TestClass]
    public class TestGetEndPoint
    {
        private String getUrl = "https://localhost:8080/laptop-bag/webapi/api/all";

        [TestMethod]
        public void TestGetUsingRestSharp()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(getUrl);
            IRestResponse restResponse= restClient.Get(restRequest);
            
            if (restResponse.IsSuccessful)
            {
                Console.WriteLine("Status Code: " + restResponse.StatusCode);
                Console.WriteLine("Response Content : " + restResponse.Content);
            }
        }

        [TestMethod]
        public void TestGetWithJson_Deserialize()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(getUrl);
            restRequest.AddHeader("Accept", "application/json");
            IRestResponse<List<JsonRootObject>> restResponse = restClient.Get<List<JsonRootObject>>(restRequest);

            if (restResponse.IsSuccessful)
            {
                Console.WriteLine("Status Code: " + restResponse.StatusCode);
                Console.WriteLine("Size of list : " + restResponse.Data.Count);
            }
            else
            {
                Console.WriteLine(restResponse.ErrorMessage);
                Console.WriteLine(restResponse.ErrorException);
            }
        }
    }
}
