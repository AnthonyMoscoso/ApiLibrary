﻿using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Files;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Files
{
    public class DocumentFileRepositorie : Repositorie<DocumentFile>, IDocumentFileRepositorie
    {
        public DocumentFileRepositorie(string identificator="IdDocument") : base(identificator)
        {
        }
    }
}