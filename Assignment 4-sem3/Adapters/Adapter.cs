using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_sem3.Adapters
{
    class Adapter
    {
        private string baseUrl = "https://foodgroup.herokuapp.com";

        public string TodaySpecial
        {
            get => String.Format(baseUrl + "/api/today-special");
        }
        public string CategoryDetail(int id)
        {
            return String.Format(baseUrl + "/api/category/" + id);
        }
    }
}
