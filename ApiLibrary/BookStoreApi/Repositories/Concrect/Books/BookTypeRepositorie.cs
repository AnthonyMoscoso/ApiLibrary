﻿using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Books;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Books
{
    public class BookTypeRepositorie : Repositorie<BookType>, IBookTypeRepositorie
    {
        public BookTypeRepositorie(string identificator= "IdType") : base(identificator)
        {
        }
    }
}