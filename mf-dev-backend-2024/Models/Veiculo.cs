﻿using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
    }
}
