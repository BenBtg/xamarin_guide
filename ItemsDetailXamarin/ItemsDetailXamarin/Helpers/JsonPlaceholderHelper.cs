﻿using System;
using System.Collections.Generic;
using RandomListXamarin.Model;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
namespace ItemsDetailXamarin.Helpers
{
    public static class JsonPlaceholderHelper
    {
        const string BASE_URL = "https://jsonplaceholder.typicode.com/";
        const string POST_ENDPOINT = "posts";

        public static async Task<List<Post>> GetPostsAsync()
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var result = await httpClient.GetStringAsync(BASE_URL + POST_ENDPOINT);
                    var posts = JsonConvert.DeserializeObject<List<Post>>(result);
                    return posts;
                }
                catch (Exception e)
                {
                    return new List<Post>();
                }
            }
        }
    }
}
