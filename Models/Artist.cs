using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moment3_CD.Models;

public class Artist
{
    [Key]
    public int? Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
               ApplyFormatInEditMode = true)]
    public DateTime? CreatedAt { get; set; } = DateTime.Now;


}