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
        public double Input1 { get; set; }
        [Required]
        public double Input2 { get; set; }
        [Required]
        public double Input3 { get; set; }
        [Required]
        public double Perimeter { get; set; }
        [Required]
        public double Area { get; set; }
        [Required]
        public DateTime DateOfGeometryResult { get; set; }
        [Required]
        public bool IsActive { get; set; }


    }
}
