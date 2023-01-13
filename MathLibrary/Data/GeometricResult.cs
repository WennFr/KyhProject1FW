using System.ComponentModel.DataAnnotations;

namespace ServiceLibrary.Data
{
    public class GeometricResult
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public Shape Shape { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        public double Width { get; set; }
        [Required]
        public double Perimiter { get; set; }
        [Required]
        public double Area { get; set; }
        [Required]
        public DateTime DateOfGeometricResult { get; set; }
        [Required]
        public bool IsActive { get; set; }


    }
}
