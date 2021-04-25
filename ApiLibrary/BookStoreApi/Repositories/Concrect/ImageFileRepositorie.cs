using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Models.Utilities;
using BookStoreApi.Repositories.Abstract.Files;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Files
{
    public class ImageFileRepositorie :Repository <ImageFile,ImageFileDto> ,IImageFileRepositorie
    {
        public ImageFileRepositorie(string identificator= "IdImageFile") : base(identificator)
        {
        }

     

        public dynamic Download(ImageFile imageFile)
        {
            string formato = Path.GetExtension(imageFile.ImageType);
            string name = Path.GetFileNameWithoutExtension(imageFile.ImageFileName);
            string directorio = HttpContext.Current.Server.MapPath(@"~/Content/" + imageFile.FileDir + name + formato);
            var stream = File.OpenRead(HttpContext.Current.Server.MapPath(@"~/Content/Images/image_not_found.jpg"));
            if (File.Exists(directorio))
            {
                stream = File.OpenRead(directorio);
            }
            var response = new System.Net.Http.HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new System.Net.Http.StreamContent(stream)
            };

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/" + imageFile.ImageType);
            response.Content.Headers.ContentLength = stream.Length;

            return response;
        }


        public dynamic RemoveFile(ImageFile image)
        {
            throw new NotImplementedException();
        }

        public dynamic Update(ImageFile imageFile)
        {
            throw new NotImplementedException();
        }

        public dynamic Upload()
        {
            var httpRequest = HttpContext.Current.Request;
            var directory = httpRequest["Directory"];
            var format = httpRequest["Format"];
            var name = httpRequest["Name"];
            bool finish = false;
            string ruta = "";
            MessageControl message = new MessageControl();
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];

                    if (postedFile != null && postedFile.ContentLength > 0)
                    {
                        try
                        {
                            string dir = HttpContext.Current.Server.MapPath(@"~/Content/Images/" + directory);
                            if (!Directory.Exists(dir))
                            {
                                DirectoryInfo di = Directory.CreateDirectory(dir);
                            }
                             ruta = $"{dir}/{name}.{format}";

                            postedFile.SaveAs(ruta);
                        finish = true;
                        }
                        catch (Exception e)
                        {
                        message.Code = 2;
                        message.Error = true;
                        message.Type = "Error";
                        message.Note = e.Message + e.InnerException;
                    }

                    }
                }
            
            if (finish)
            {
                message.Code = 1;
                message.Error = false;
                message.Type = "Data";
                message.Note = ruta;
            }
       
            return message;
        }
    }
}