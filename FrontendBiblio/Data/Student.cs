using System.ComponentModel.DataAnnotations;

namespace backendbiblioteca.Modelo
{
    public class Student
    {
        [Key]
        public int Semester { get; set; }
        public string Name { get; set; }
        public string Carreer { get; set; }
        public int IDStudent { get; set; }
        public int Loans { get; set; }
    }
}