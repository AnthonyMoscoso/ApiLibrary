using Core.FileService.Abstracts;
using Core.FileService.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Core.FileService.Specifics
{
    public class FileServiceBase : IFileServices
    {
        private readonly string _defaultDir = ".";
        private string _urlFile = string.Empty;
        public FileServiceBase()
        {

        }

        public FileServiceBase(string defaultDir)
        {
            _defaultDir = defaultDir;
        }

        public Stream DownLoad(string fileName, string fileDir = "", FileType fileType = FileType.jpeg)
        {
            if (string.IsNullOrEmpty(fileDir))
            {
                fileDir = _defaultDir;
            }
            if (fileType == FileType.pdf)
            {
                _urlFile = $@"{UrlDirectoryFiles.DocumentDirectory}\{fileDir}\{fileName}";
            }
            else
            {
                _urlFile = $@"{UrlDirectoryFiles.ImageDirectory}\{fileDir}\{fileName}";
             
            }
            if (File.Exists(_urlFile))
            {
                Stream stream = File.OpenRead(_urlFile);
                return stream;
            }
            else
            {
                throw new Exception();
            }



        }

        public string Upload(Stream stream, string fileName, string dir = "", FileType fileType = FileType.jpeg)
        {
            _urlFile = GetUrlFile(fileName, dir, fileType);

            using (FileStream fileStream = new FileStream(_urlFile, FileMode.Create))
            {
                stream.CopyTo(fileStream);
                fileStream.Close();
            }
              
            return _urlFile;
        }

        public string Upload(byte[] bytes, string fileName, string dir = "", FileType fileType = FileType.jpeg)
        {
            _urlFile = GetUrlFile(fileName, dir, fileType);
            File.WriteAllBytes(_urlFile, bytes);
            return _urlFile;
        }

        public string Upload(string base64, string fileName, string dir = "", FileType fileType = FileType.jpeg)
        {

            _urlFile = GetUrlFile(fileName,dir,fileType);
            File.WriteAllBytes(_urlFile, Convert.FromBase64String(base64));
            return _urlFile;
        }


        private string GetUrlFile(string fileName,string dir="",FileType fileType = FileType.jpeg)
        {
            string format;
            if (string.IsNullOrEmpty(dir))
            {
                dir = _defaultDir;
            }
            if (fileType == FileType.pdf)
            {
                format = "pdf";
                _urlFile = $@"{UrlDirectoryFiles.DocumentDirectory}\{dir}\{fileName}.{format}";

            }
            else
            {
                format = Path.GetExtension(fileName);
                if (format.Equals(".jpg"))
                {
                    format = ".jpeg";
                }
                _urlFile = $@"{UrlDirectoryFiles.ImageDirectory}\{dir}\{fileName}.{format}";


            }

            return _urlFile;
        }
    }
}
