using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBO_Dictionary.BusinessLogicLayer
{
    public struct PlayerModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string team { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public DateTime birth_date { get; set; }
        public int 경기수 { get; set; }
        public int 타석 { get; set; }
        public double 타율 { get; set; }
        public int 안타 { get; set; }
        public int 이루타 { get; set; }
        public int 삼루타 { get; set; }
        public int 홈런 { get; set; }
        public int 득점 { get; set; }
        public int 타점 { get; set; }
        public double 장타율 { get; set; }
        public double 출루율 { get; set; }
        public double ops { get; set; }
    }
}