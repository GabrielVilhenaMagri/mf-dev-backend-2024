using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo obrigatorio")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        public DateTime Data { get; set; }


        [Required(ErrorMessage = "Campo obrigatorio")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Quilometragem")]
        public int km { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Tipo de combustivel")]
        public TipoCombustivel Tipo { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Veiculo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }


    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
