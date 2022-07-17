using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ApiTestMVC.Models;
using Newtonsoft.Json;

namespace ApiTestMVC.Controllers
{
    public class PersonController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<PersonAll> list = new List<PersonAll>();
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("http://localhost:36812/api/persons/");
            
            string jstring = await message.Content.ReadAsStringAsync();
            if (message.IsSuccessStatusCode)
            {
                list = JsonConvert.DeserializeObject<List<PersonAll>>(jstring);
                return View(list);
            }
            return View(list);
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
