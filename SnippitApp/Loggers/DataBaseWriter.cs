using Newtonsoft.Json;
using SnippitApp.Snippits;
using System.Net.Http;
using System.Text;

namespace SnippitApp.Loggers
{
    internal class DataBaseWriter : IWriter
    {
        public async void WriteTo(CodeSnippit snippit)
        {
            var json = JsonConvert.SerializeObject(snippit);

            using var client = new HttpClient();
            var response = await client.PostAsync(
                "https://snippit-app.herokuapp.com/snippits",
                new StringContent(json, Encoding.UTF8, "application/json"));
        }

        public async void DeletePost(CodeSnippit snippit)
        {
            var id = snippit.Id;

            var json = JsonConvert.SerializeObject(snippit);

            using var client = new HttpClient();
            var response = await client.DeleteAsync(
                "https://snippit-app.herokuapp.com/snippits/" + id);
        }

        public async void UpdatePost(CodeSnippit snippit)
        {
            var id = snippit.Id;

            var json = JsonConvert.SerializeObject(snippit);

            using var client = new HttpClient();
            var response = await client.PatchAsync(
                "https://snippit-app.herokuapp.com/snippits/" + id,
                new StringContent(json, Encoding.UTF8, "application/json"));
        }

        public void WriterTo()
        {
        }
    }
}