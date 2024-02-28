using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using KBO_Dictionary.DataAccessLayer;
using KBO_Dictionary.EntityLayer;
using Image = System.Drawing.Image;

namespace KBO_Dictionary.BusinessLogicLayer
{
    public class ApiDataSaverService
    {
        ITeamInformationDao _infoDao;

        public void Invoke()
        {
            //todo: 1. getDataFromApi
            //todo: 2. transferIntoFItModel
            //todo: 3. InsertToDatabase
        }

        public void GetDataFromApi()
        {
        }

        public void TransferIntoFitModel()
        {
        }


        public void InsertToDatabase()
        {
        }

        public void UpdateTeamInformation()
        {
            _infoDao = new TeamInformationDao();
            var ms = new MemoryStream();
            var stringPath = @"C:\1정호준\Image\LgTwins.png";
            var image = Image.FromFile(stringPath);
            image.Save(ms, ImageFormat.Png);
            var byteArray = ms.ToArray();
            _infoDao.Update(new TeamInformationEntity() { Id = 1, Name = "LG트윈스", TeamImage = byteArray });
        }
    }
}