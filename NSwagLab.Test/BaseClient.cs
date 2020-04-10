using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NSwagLab.Client
{
    public class BaseClient
    {
        public Config Configuration { get; set; }
        public BaseClient(Config configuration)
        {
            Configuration = configuration;
        }

        protected async Task<HttpClient> CreateHttpClientAsync(CancellationToken cancellationToken)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Configuration.BaseUrl);
            return await Task.FromResult(client);
        }
    }
}
