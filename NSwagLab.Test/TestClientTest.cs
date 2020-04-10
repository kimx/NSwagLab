using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSwagLab.Client;

namespace NSwagLab.Test
{
    [TestClass]
    public class TestClientTest
    {

        [TestMethod]
        public async Task GetAsyncTest()
        {
            Config config = new Config("http://localhost:53060/");
            TestClient ugozClient = new TestClient(config);
            var result = await ugozClient.GetAsync(1);
            Assert.AreEqual(result.ID, 1);
        }
    }
}
