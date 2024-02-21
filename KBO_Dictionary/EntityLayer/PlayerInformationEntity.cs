using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBO_Dictionary.EntityLayer
{
    [Table("PLAYER_INFO")]
    public class PlayerInformationEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [Column("height")]
        public double Height { get; set; }

        [Required]
        [Column("weight")]
        public double Weight { get; set; }

        [Column("birth_date")]
        public DateTime BirthDate { get; set; }

        [Column("team_id")]
        public short TeamId { get; set; }

        [ForeignKey("TeamId")]
        public virtual TeamInformationEntity? TeamInformation { get; set; }
    }
}
