using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class ImageFileDto
    {
        public string IdImageFile { get; set; }
        public string FileDir { get; set; }
        public string ImageFileName { get; set; }
        public string ImageType { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    }
}