using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace KBO_Dictionary.DataAccessLayer
{
    public class TeamImageCacheService
    {
        public static TeamImageCacheService? Service;

        private TeamImageCacheService()
        {
        }

        public static TeamImageCacheService Instance()
        {
            return Service ??= new TeamImageCacheService();
        }

        public List<BitmapImageAndId> GetBitmapImages()
        {
            var dao = new TeamInformationDao();
            var teamImageList = dao.SelectAll().Select(a => (a.Id, a.TeamImage));
            return teamImageList.Select(ConvertByteArrayToBitmapImage).ToList();
        }

        private BitmapImageAndId ConvertByteArrayToBitmapImage((short id, byte[] image) idAndImage)
        {
            var bitmap = new BitmapImage();
            using var stream = new MemoryStream(idAndImage.image);
            bitmap.BeginInit();
            bitmap.CacheOption = BitmapCacheOption.OnLoad;
            bitmap.StreamSource = stream;
            bitmap.EndInit();
            bitmap.Freeze();

            return new BitmapImageAndId(idAndImage.id, bitmap);
        }

        public record BitmapImageAndId(short Id, BitmapImage Image);
    }
}
