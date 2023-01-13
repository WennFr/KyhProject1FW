using System.ComponentModel.DataAnnotations;

namespace ServiceLibrary.Data
{
    public class GeometryResult
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
        public DateTime DateOfGeometryResult { get; set; }
        [Required]
        public bool IsActive { get; set; }


    }
}
