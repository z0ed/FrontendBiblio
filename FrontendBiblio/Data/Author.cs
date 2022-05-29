
using System.ComponentModel.DataAnnotations;

namespace backendbiblioteca.Modelo
{
    public class Author
    {
        [Key]
        public int Books { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int AuthorID { get; set; }
        public string Cathegory { get; set; }
    }
}