namespace Assignment_4_sem3.Models
{
    using System.Collections.Generic;

    internal class Data
    {
        public MenuItem category { get; set; }

        public List<Product> foods { get; set; }
    }

    internal class CategoryDetail
    {
        public string message { get; set; }

        public Data data { get; set; }
    }
}
