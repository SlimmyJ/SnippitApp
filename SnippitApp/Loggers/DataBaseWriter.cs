using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SnippitApp
{
    internal class DataBaseWriter : Writer
    {
        public async void WriteTo(CodeSnippit snippit)
        {
            string json = JsonConvert.SerializeObject(snippit);

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(
                    "https://snippit-app.herokuapp.com/snippits",
                     new StringContent(json, Encoding.UTF8, "application/json"));
            }
        }

        public async void DeletePost(CodeSnippit snippit)
        {
            string id = snippit._id;            

            string json = JsonConvert.SerializeObject(snippit);

            using (var client = new HttpClient())
            {
                var response = await client.DeleteAsync(
                    "https://snippit-app.herokuapp.com/snippits/" + id);                     
            }
        }

        public async void UpdatePost(CodeSnippit snippit)
        {
            string id = snippit._id;

            string json = JsonConvert.SerializeObject(snippit);

            using (var client = new HttpClient())
            {
                var response = await client.PatchAsync(
                    "https://snippit-app.herokuapp.com/snippits/" + id,
                     new StringContent(json, Encoding.UTF8, "application/json"));
            }
        }
    }
}