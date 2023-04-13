﻿using CnGalWebSite.Core.Services;
using CnGalWebSite.RobotClient.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CnGalWebSite.RobotClient.Services.Https
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _client;

        private readonly JsonSerializerOptions _jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true,
        };

        public bool IsAuth { get; set; }

        public HttpService(HttpClient client)
        {
            _client = client;

            _jsonOptions.Converters.Add(new DateTimeConverterUsingDateTimeParse());
            _jsonOptions.Converters.Add(new DateTimeConverterUsingDateTimeNullableParse());
        }
        public async Task<TValue> GetAsync<TValue>(string url)
        {
            var client = await GetClientAsync();
            return await client.GetFromJsonAsync<TValue>(url, _jsonOptions);
        }

        public async Task<TValue> PostAsync<TModel, TValue>(string url, TModel model)
        {
            var client = await GetClientAsync();
            var result = await client.PostAsJsonAsync(url, model);
            string jsonContent = result.Content.ReadAsStringAsync().Result;
            return JsonSerializer.Deserialize<TValue>(jsonContent, _jsonOptions);
        }

        public async Task<HttpClient> GetClientAsync()
        {
            return await Task.FromResult(_client);
        }

        public HttpClient GetClient()
        {
            return _client;

        }
    }
}
