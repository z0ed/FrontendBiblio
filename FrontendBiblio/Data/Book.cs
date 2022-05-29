using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBiblio.Data 
{
    public class Book
    {
        [Key]
        public int Page { get; set; }
        public string Title { get; set; }
        public string Editorial { get; set; }
        public string Author { get; set; }
        public int BookID { get; set; }
        public string Description { get; set; }
    }
}