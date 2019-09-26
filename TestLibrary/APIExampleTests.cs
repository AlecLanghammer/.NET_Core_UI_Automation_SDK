using RestSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using APIObjects;

namespace TestLibrary
{
    [TestClass]
    public class ExampleTests
    {
        [TestMethod, TestCategory("Example GET")]
        public void GETPlaceHolder()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("todos/1", Method.GET);
            var response = client.Execute(request);
            var arr = JsonConvert.DeserializeObject<Todos>(response.Content);
            int userId = arr.UserId;
            int id = arr.Id;
            string title = arr.Title;
            bool completed = arr.Completed;
            Assert.AreEqual(1, userId);
            Assert.AreEqual(1, id);
            Assert.AreEqual("delectus aut autem", title);
            Assert.AreEqual(false, completed);
        }

        [TestMethod, TestCategory("Example POST")]
        public void POSTPlaceHolder()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("posts", Method.POST);
            request.AddParameter("title", "foo");
            request.AddParameter("userid", 7);
            request.AddParameter("body", "bar");
            var response = client.Execute(request);
            var arr = JsonConvert.DeserializeObject<Posts>(response.Content);
            int userId = arr.UserId;
            int id = arr.Id;
            string title = arr.Title;
            string body = arr.Body;
            Assert.AreEqual(7, userId);
            Assert.AreEqual(101, id);
            Assert.AreEqual("foo", title);
            Assert.AreEqual("bar", body);
        }
    }
}