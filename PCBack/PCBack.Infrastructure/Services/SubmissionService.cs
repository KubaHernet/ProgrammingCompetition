using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using PCBack.Application.Interfaces;
using PCBack.Infrastructure.Settings;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PCBack.Infrastructure.Services
{
    public class SubmissionService : ISubmissionService
    {
        private readonly HttpClient httpClient;
        private readonly CompilerApiSettings compilerSettings;

        public SubmissionService(HttpClient httpClient, IOptions<CompilerApiSettings> compilerOptions)
        {
            this.httpClient = httpClient;
            compilerSettings = compilerOptions.Value;
        }

        public async Task<string> Execute((string language, string code, string input) requestParams, CancellationToken cancellationToken)
        {
            var requestBody = new
            {
                clientId = compilerSettings.ClientId,
                clientSecret = compilerSettings.ClientSecret,
                script = requestParams.code,
                language = requestParams.language,
                args = requestParams.input
            };

            var stringContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(httpClient.BaseAddress, content: stringContent, cancellationToken);

            return response.IsSuccessStatusCode
                ? JsonConvert.DeserializeObject<CompilerResponse>(await response.Content.ReadAsStringAsync(cancellationToken)).Output
                : null;
        }

        class CompilerResponse
        {
            private string output;
            public string Output 
            {
                get => output;
                set => output = value?.TrimEnd('\n');
            }
        }
    }
}
