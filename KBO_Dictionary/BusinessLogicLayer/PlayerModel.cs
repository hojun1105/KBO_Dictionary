using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace KBO_Dictionary.BusinessLogicLayer
{
    public struct PlayerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public BitmapImage TeamImage { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public DateTime BirthDate { get; set; }
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
        public double Ops { get; set; }
    }
}