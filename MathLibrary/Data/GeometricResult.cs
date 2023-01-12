using System.ComponentModel.DataAnnotations;

namespace MainMenuApp.Data
{
    public class GeometricResult
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public Shape Shape { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public int Perimiter { get; set; }
        [Required]
        public int Area { get; set; }
        [Required]
        public DateTime DateOfGeometricResult { get; set; }
        [Required]
        public bool IsActive { get; set; }


    }
}
