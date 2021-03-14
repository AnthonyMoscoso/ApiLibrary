using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Files;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Files
{
    public class ImageFileRepositorie :Repositorie <ImageFile> ,IImageFileRepositorie
    {
        public ImageFileRepositorie(string identificator= "IdImageFile") : base(identificator)
        {
        }

        public dynamic DonwloadImage(ImageFile imageFile)
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

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/"+imageFile.ImageType);
            response.Content.Headers.ContentLength = stream.Length;

            return response;
        }

        public dynamic InsertImage(ImageFile imageFile)
        {
            var httpRequest = HttpContext.Current.Request;
            bool finish = false;
            foreach (string file in httpRequest.Files)
            {
                var postedFile = httpRequest.Files[file];
                if (postedFile != null && postedFile.ContentLength > 0)
                {
                    string ruta = HttpContext.Current.Server.MapPath(@"~/Content/Images/"+imageFile.FileDir + imageFile.ImageFileName);

                    postedFile.SaveAs(ruta);
                    finish = true;
                }
            }

            return Insert(imageFile);
        }
    }
}