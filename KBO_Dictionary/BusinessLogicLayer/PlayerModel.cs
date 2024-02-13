using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBO_Dictionary.BusinessLogicLayer
{
    public sealed class PlayerModel
    {
        private int id { get; set; }
        private string name { get; set; }
        private string team { get; set; }
        private double height { get; set; }
        private double width { get; set; }
        private DateTime birth_date { get; set; }
        private double 타율 { get; set; }
        private int 경기수 { get; set; }
        private int 득점 { get; set; }
        private int 안타 { get; set; }
        private int 이루타 { get; set; }
        private int 삼루타 { get; set; }
        private int 홈런 { get; set; }
        private int 타점 { get; set; }
        private double 장타율 { get; set; }
        private double 출루율 { get; set; }
        private double ops { get; set; }
    }
}