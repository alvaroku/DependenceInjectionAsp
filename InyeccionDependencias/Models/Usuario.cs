using System.ComponentModel.DataAnnotations.Schema;

namespace InyeccionDependencias.Models
{
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
