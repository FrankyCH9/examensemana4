﻿using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json; // biblioteca Newtonsoft.Json 

namespace lab2.Pages;
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public List<Tienda> Data { get; private set; } // Reemplaza 'MyModel' con el tipo de tus datos

        public async Task OnGetAsync()
        {
            var httpClient = _httpClientFactory.CreateClient();
            // URL de tu API
            var apiUrl = "https://teamapi.bladimirchipana.repl.co/pruebas"; //modicar si tenemos problemas en el docker
            var response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Data = JsonConvert.DeserializeObject<List<Tienda>>(content); // Reemplaza 'MyModel'
            }
            else
            {
                // Maneja errores de solicitud aquí
            }
        }
    }