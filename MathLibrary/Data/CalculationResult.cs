using System.ComponentModel.DataAnnotations;

namespace ServiceLibrary.Data
{
    public class CalculationResult
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double FirstNumber { get; set; }
        [Required]
        public char Operator { get; set; }
        [Required]
        public double SecondNumber { get; set; }
        [Required]
        public double EquationResult { get; set; }
        [Required]
        public DateTime DateOfCalculation { get; set; }
        [Required]
        public bool IsActive { get; set; }



    }
}
