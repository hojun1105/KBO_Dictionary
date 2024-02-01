using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBO_Dictionary.EntityLayer
{
    public class PlayerInformationEntity
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Team { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public DateTime Birth_date { get; set; }
    }
}
