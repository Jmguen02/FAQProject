namespace FAQProject.Models
{
    public class FAQViewModel
    {
        public FAQ FAQ { get; set; }
        public string ActiveTopic { get; set; } = "all";
        public string ActiveCat { get; set; } = "all";
    }
}
