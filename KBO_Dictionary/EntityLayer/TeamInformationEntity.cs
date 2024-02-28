using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBO_Dictionary.EntityLayer
{
    [Table("TEAM_INFO")]
    public class TeamInformationEntity
    {
        [Key]
        [Column("id")]
        public short Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("team_image")]
        public byte[] TeamImage { get; set; }

        public ICollection<PlayerInformationEntity> Players { get; set; }
    }
}
