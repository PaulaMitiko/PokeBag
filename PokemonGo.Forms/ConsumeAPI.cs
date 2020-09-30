using Newtonsoft.Json;
using PokemonGo.Context.Utilitarios;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PokemonGo.Forms
{
    public class ConsumeAPI<T>
    {
        public string ConsumePutAPI(string url)
        {
            var httpClient = new HttpClient();
            var resultRequest = httpClient.PutAsync(url, null);
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var resultBody = JsonConvert.DeserializeObject<Result<T>>(result.Result);

            return resultBody.Message;
        }

        public (string, bool) ConsumePostAPI(string url, T conteudo)
        {
            var newJson = JsonConvert.SerializeObject(conteudo);
            StringContent content = new StringContent(newJson, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var resultRequest = httpClient.PostAsync(url, content);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var resultBody = JsonConvert.DeserializeObject<Result<List<T>>>(result.Result);

            return (resultBody.Message, resultBody.Error);
        }

        public Result<List<T>> ConsumeDeleteAPI(string url)
        {
            var httpClient = new HttpClient();
            var resultRequest = httpClient.DeleteAsync(url);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var resultBody = JsonConvert.DeserializeObject<Result<List<T>>>(result.Result);

            return resultBody;
        }

        public List<T> ConsumeGetAPI(string url)
        {
            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(url);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;
            return data;
        }

        private class Root
        {
            public List<T> Data { get; set; }
        }
    }
}
