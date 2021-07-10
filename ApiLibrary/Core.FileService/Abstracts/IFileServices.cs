using Core.FileService.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Core.FileService.Abstracts
{
    public interface IFileServices
    {
        string Upload(Stream stream,string fileName , string dir = "", FileType fileType = FileType.jpeg);
        string Upload(byte[] bytes, string fileName, string dir = "", FileType fileType = FileType.jpeg);
        string Upload(string base64,string fileName, string dir = "", FileType fileType = FileType.jpeg);
        Stream DownLoad(string fileName, string fileDir = "", FileType fileType = FileType.jpeg);
    }
}
