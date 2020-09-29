using Assignment_4_sem3.Adapters;
using Assignment_4_sem3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_4_sem3.Services
{
    class CategoryService
    {
        private Adapter _adapter = new Adapter();

        public async Task<CategoryDetail> CategoryDetail(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(_adapter.CategoryDetail(id));
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<CategoryDetail>(stringContent);
            }
            return null;
        }
    }
}
