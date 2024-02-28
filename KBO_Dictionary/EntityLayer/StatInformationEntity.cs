using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBO_Dictionary.EntityLayer
{
    [Table("STAT_INFO")]
    public class StatInformationEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("games")]
        public int Games { get; set; }

        [Column("plate_appearance")]
        public int PlateAppearance { get; set; }

        [Column("at_bat")]
        public int AtBat { get; set; }

        [Column("run")]
        public int Run { get; set; }

        [Column("hit")]
        public int Hit { get; set; }

        [Column("double_hit")]
        public int DoubleHit { get; set; }

        [Column("triple_hit")]
        public int TripleHit { get; set; }

        [Column("home_run")]
        public int HomeRun { get; set; }

        [Column("runs_batted_in")]
        public int RunsBattedIn { get; set; }

        [Column("slugging_percentage")]
        public double SluggingPercentage { get; set; }

        [Column("on_base_percentage")]
        public double OnBasePercentage { get; set; }

        [Column("on_base_plus_slugging")]
        public double OnBasePlusSlugging { get; set; }

        [Column("average")]
        public double Average { get; set; }
    }
}
