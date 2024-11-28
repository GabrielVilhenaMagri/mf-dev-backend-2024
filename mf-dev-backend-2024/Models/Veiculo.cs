using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        public int AnoModelo { get; set; }
    }
}
