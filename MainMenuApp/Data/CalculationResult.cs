using System.ComponentModel.DataAnnotations;

namespace MainMenuApp.Data
{
    public class CalculationResult
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int FirstNumber { get; set; }
        [Required]
        public string Operator { get; set; }
        [Required]
        public int SecondNumber { get; set; }
        [Required]
        public int EquationResult { get; set; }
        [Required]
        public DateTime DateOfCalculation { get; set; }
        [Required]
        public bool IsActive { get; set; }

    }
}
