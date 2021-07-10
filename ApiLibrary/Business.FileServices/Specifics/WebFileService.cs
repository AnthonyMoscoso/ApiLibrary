using Business.FileServices.Abstracts;
using Core.FileService.Enums;
using Core.FileService.Specifics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Business.FileServices.Specifics
{
    public class WebFileService : FileServiceBase, IWebFileService
    {


        public dynamic DonwloadFromWeb(string fileName, string fileDir = "", FileType fileType = FileType.jpeg)
        {
            Stream stream = DownLoad(fileName, fileDir, fileType);
            string header;
            if (fileType == FileType.pdf)
            {
                header = "application/pdf";
            }
            else
            {

                if (fileType == FileType.jpg)
                {
                    fileType = FileType.jpeg;
                }
                header = $"image/{Enum.GetName(typeof(FileType), fileType)}";
            }
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StreamContent(stream)
            };
            httpResponseMessage.Content.Headers.ContentType = new MediaTypeHeaderValue(header);
            httpResponseMessage.Content.Headers.ContentLength = stream.Length;
            return httpResponseMessage;
        }




        public dynamic UploadFromHttpRequest()
        {
            HttpRequest httpRequest = HttpContext.Current.Request;
            string directory = httpRequest["Directory"];
            string fileFormat = httpRequest["Format"];
            string fileName = httpRequest["Name"];
            string DocumentType = httpRequest["Type"];
            string url_file = string.Empty;
            if (string.IsNullOrEmpty(directory) && string.IsNullOrEmpty(fileFormat) && string.IsNullOrEmpty(fileName) && string.IsNullOrEmpty(DocumentType))
            {
                throw new Exception("File datas must be complete");
            }
            else
            {
                if (httpRequest.Files != null && httpRequest.Files.Count > 0)
                {
                    foreach (string file in httpRequest.Files)
                    {
                        HttpPostedFile postedFile = httpRequest.Files[file];

                        if (postedFile != null && postedFile.ContentLength > 0)
                        {

                            string url_dir = string.Empty;
                            if (DocumentType.Equals("Image"))
                            {
                                url_dir = $"{UrlDirectoryFiles.ImageDirectory}/{directory}";
                            }
                            else if (DocumentType.Equals("Document"))
                            {
                                url_dir = $"{UrlDirectoryFiles.DocumentDirectory}/{directory}";
                            }

                            if (!Directory.Exists(url_dir))
                            {
                                DirectoryInfo di = Directory.CreateDirectory(url_dir);
                            }

                            url_file = $@"{url_dir}\{fileName}.{fileFormat}";
                            postedFile.SaveAs(url_file);

                        }
                        else
                        {
                            throw new Exception("file dont have send");
                        }
                    }
                }
                else
                {
                    throw new Exception("Error format to upload file ");
                }
            }
         
            return url_file;
        }
    }
}
