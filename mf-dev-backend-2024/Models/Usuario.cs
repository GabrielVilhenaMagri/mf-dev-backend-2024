using System.ComponentModel.DataAnnotations;

namespace mf_dev_backend_2024.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Campo obrigatorio")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        User
    }
}
