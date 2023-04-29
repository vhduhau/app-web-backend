using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Veículos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório infomar o nome!")] // Terá validação no Front e End

        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório infomar o !")] // Terá validação no Front e End

        public string Placa { get; set; }
    }
}
