using System.Collections.Generic;

namespace FAQProject.Models
{
    public class FAQListViewModel : FAQViewModel
    {
        public List<FAQ> FAQs { get; set; }

        private List<Topic> topics;
        public List<Topic> Topics
        {
            get => topics;
            set
            {
                topics = new List<Topic> { 
                };
                topics.AddRange(value);
            }
        }

        private List<Category> categories;
        public List<Category> Categories
        {
            get => categories;
            set
            {
                categories = new List<Category>
                {
                };
                categories.AddRange(value);
            }
        }

        public string CheckActiveTopic(string t) => t.ToLower() == ActiveTopic.ToLower() ? "active" : "";
        public string CheckActiveCat(string c) => c.ToLower() == ActiveCat.ToLower() ? "active" : "";
    }
}
