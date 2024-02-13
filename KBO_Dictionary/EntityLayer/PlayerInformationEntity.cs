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
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Name { get; set; }

        [ForeignKey("team_id")] public short TeamId { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
