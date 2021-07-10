using Core.FileService.Abstracts;
using Core.FileService.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FileServices.Abstracts
{
    public interface IWebFileService : IFileServices
    {
        dynamic UploadFromHttpRequest();
        dynamic DonwloadFromWeb(string fileName, string fileDir = "", FileType fileType = FileType.jpeg);
    }
}
