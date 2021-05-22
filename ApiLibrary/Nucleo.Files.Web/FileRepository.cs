using Nucleo.Utilities;
using Nucleo.Utilities.Enums;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Nucleo.Files.Web
{
    public class FileRepository : IFileRepository
    {
        public  dynamic Delete(int type, string dir, string name,string format)
        {
            string directory = "";

            if (type == (int)FileType.Document)
            {
                directory = $"{UrlDirectoryFiles.DocumentDirectory}/{dir}/{name}.{format}";
            }
            else if (type == (int)FileType.Image)
            {
                directory = $"{UrlDirectoryFiles.ImageDirectory}/{dir}/{name}.{format}";
         
            }
            MessageControl message = new MessageControl();
            if (File.Exists(directory))
            {
                try
                {
                    File.Delete(directory);
                    message.Code = MessageCode.correct;
                    message.Type = MessageType.Not_Found;
                    message.Error = false;
                    message.Note = $" {Enum.GetName(typeof(FileType), type)} : {name} in directory {dir} was delete ";
                    
                }
                catch (Exception e)
                {
                    message.Code = MessageCode.exception;
                    message.Error = true;
                    message.Type = MessageType.Exception;
                    message.Note = e.Message + e.InnerException;
                }
                
            }
            return message;
        }

        public dynamic DownLoad(int type,string dir,string name)
        {
            string directory = "";
            string header = "";
   
            if (type==(int)FileType.Document)
            {
                directory = $"{UrlDirectoryFiles.DocumentDirectory}/{dir}/{name}";
                header = "application/pdf";
            }
            else if (type == (int)FileType.Image)
            {
                directory = $"{UrlDirectoryFiles.ImageDirectory}/{dir}/{name}";
                string format = Path.GetExtension(name);
                if (format.Equals(".jpg"))
                {
                    format = ".jpeg";
                }
                header = $"image/{format.Replace(".","")}";
            }

      
            Stream stream = null;
            if (File.Exists(directory))
            {
                stream = File.OpenRead(directory);
                var response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StreamContent(stream)
                };

                response.Content.Headers.ContentType = new MediaTypeHeaderValue(header);
                response.Content.Headers.ContentLength = stream.Length;

                return response;
            }
            else
            {
                MessageControl messageControl = new MessageControl()
                {
                    Code = MessageCode.correct,
                    Error = false,
                    Type = MessageType.Not_Found,
                    Note = $"Image Not was found"
                };

                return messageControl;
            }
    
        }

        public dynamic Upload()
        {
            var httpRequest = HttpContext.Current.Request;
            var directory = httpRequest["Directory"];
            var format = httpRequest["Format"];
            var name = httpRequest["Name"];
            var DocumentType = httpRequest["Type"];
            string ruta = "";
            MessageControl message = new MessageControl();
            foreach (string file in httpRequest.Files)
            {
                var postedFile = httpRequest.Files[file];

                if (postedFile != null && postedFile.ContentLength > 0)
                {
                    try
                    {
                        string dir = "";
                        if (DocumentType.Equals("Image"))
                        {
                           dir = $"{UrlDirectoryFiles.ImageDirectory}/{directory}";
                        }
                        else if (DocumentType.Equals("Document"))
                        {
                            dir = $"{UrlDirectoryFiles.DocumentDirectory}/{directory}";
                        }
                      
                        if (!Directory.Exists(dir))
                        {
                            DirectoryInfo di = Directory.CreateDirectory(dir);
                        }
                        ruta = $"{dir}/{name}.{format}";
                        postedFile.SaveAs(ruta);
                    }
                    catch (Exception e)
                    {
                        message.Code = MessageCode.exception;
                        message.Error = true;
                        message.Type = MessageType.Exception;
                        message.Note = e.Message + e.InnerException;
                    }

                }
            }
            return message;
        }
    }
}