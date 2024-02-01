using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBO_Dictionary.BusinessLogicLayer
{
    public class PlayerStatModel
    {
        private double average { get; set; }
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
