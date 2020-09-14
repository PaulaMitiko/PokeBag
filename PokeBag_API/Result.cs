using System.Net;

namespace PokeBag_API
{
    public class Result<T>
    {
        public T Data { get; set; }
        public HttpStatusCode Status { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
    }
}
