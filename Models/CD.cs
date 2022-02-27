using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moment3_CD.Models;

// Create and handle info about CDs
public class CD
{
    [Key]
    public int? Id { get; set; }

    [Required]
   
    public string? Album { get; set; }

    [Required]
    [Column("AntalLåt")]
    public int? NbrOfTracks { get; set; }

    [Required]
    [Column("Publiceringsdatum")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
               ApplyFormatInEditMode = true)]
    public DateTime? PublishedDate { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    // Set artist ID as ForegnKey
    [Required]
    [ForeignKey("Artist")]
    [Column( "Artist" )]
    public int ArtistId { get; set; }

    public virtual Artist? Artists { get; set; }
}

