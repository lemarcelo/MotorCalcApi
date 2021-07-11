using System.ComponentModel.DataAnnotations;

namespace MotorCalcApi.Models
{
    public class Medidas
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage ="Limite 20 caracteres")]
        [MinLength(3, ErrorMessage ="Tamanho minimo 3 caracteres")]
        public string Veiculo { get; set; }
        
        [MaxLength(4, ErrorMessage ="Limite 7 caracteres")]
        [Range(3, int.MaxValue, ErrorMessage ="Tamanho minimo 3 caracteres")]
        public string Pistao { get; set; }
        
        [MaxLength(20, ErrorMessage ="Limite 7 caracteres")]
        [Range(3, int.MaxValue, ErrorMessage ="Tamanho minimo 3 caracteres")]
        public string Pino { get; set; }
        
        [MaxLength(20, ErrorMessage ="Limite 7 caracteres")]
        [Range(3, int.MaxValue, ErrorMessage ="Tamanho minimo 3 caracteres")]
        public string Curso { get; set; }
        

    }
}