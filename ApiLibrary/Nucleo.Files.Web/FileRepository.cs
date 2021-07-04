using Core.Utilities;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Core.Files.Web
{
    public class FileRepository : IFileRepository
    {
    
        public dynamic Delete(string directory,string name)
        {
            string url_file = $"{directory}/{name}";
            if (Directory.Exists(directory))
            {
                if (File.Exists(url_file))
                {
                    try
                    {
                        File.Delete(directory);
                    }
                    catch (Exception e)
                    {

                    }

                }
            }
            else
            {

            }
            return "";
          
        }

        public dynamic DownLoad(string type,string dir,string name)
        {
            string url_file = string.Empty;
            string header = string.Empty;

            switch (type)
            {
                case "Document":
                    url_file = $"{UrlDirectoryFiles.DocumentDirectory}/{dir}/{name}";
                    header = "application/pdf";
                    break;
                case "Images":
                    url_file = $"{UrlDirectoryFiles.ImageDirectory}/{dir}/{name}";
                    string format = Path.GetExtension(name);
                    if (format.Equals(".jpg"))
                    {
                        format = ".jpeg";
                    }
                    header = $"image/{format.Replace(".", "")}";
                    break;
                default:
                    break;
            }         
            if (File.Exists(url_file))
            {
                try
                {
                    Stream stream = File.OpenRead(url_file);
                    var response = new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StreamContent(stream)
                    };

                    response.Content.Headers.ContentType = new MediaTypeHeaderValue(header);
                    response.Content.Headers.ContentLength = stream.Length;

                    return response;
                }
                catch (Exception e)
                {
                    return e.InnerException?.InnerException?.Message ?? e.Message;
                }
  
            }
            else
            {
                return "File not was found";
            }
    
        }

        public dynamic Upload()
        {
            HttpRequest httpRequest = HttpContext.Current.Request;
            string directory = httpRequest["Directory"];
            string format = httpRequest["Format"];
            string name = httpRequest["Name"];
            string DocumentType = httpRequest["Type"];
            string url = string.Empty;
            if (httpRequest.Files != null && httpRequest.Files.Count>0)
            {
                foreach (string file in httpRequest.Files)
                {
                    HttpPostedFile postedFile = httpRequest.Files[file];

                    if (postedFile != null && postedFile.ContentLength > 0)
                    {
                        try
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
                            url = $"{url_dir}/{name}.{format}";
                            postedFile.SaveAs(url);
                        }
                        catch (Exception e)
                        {
                            return e.InnerException?.InnerException?.Message ?? e.Message;
                        }
                    }
                    else
                    {
                       return  "file dont have send";
                    }
                }
            }
            else
            {
                return "Error format to upload file ";
            }
            return url;
            
            
        }
    }
}