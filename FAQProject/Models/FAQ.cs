using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQProject.Models
{
    public class FAQ
    {
        public int FAQId { get; set; }

        public string FAQQuestion { get; set; }

        public string FAQAnswer { get; set; }

        public string TopicId { get; set; }
        public Topic Topic { get; set; }

        public string CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
