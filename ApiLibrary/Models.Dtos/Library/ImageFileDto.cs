﻿using System;

namespace Models.Dtos
{
    public class ImageFileDto
    {
        public string IdImageFile { get; set; }
        public string FileDir { get; set; }
        public string ImageFileName { get; set; }
        public string ImageType { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    }
}