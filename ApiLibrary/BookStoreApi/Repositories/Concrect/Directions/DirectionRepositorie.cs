﻿using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Directions;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Directions
{
    public class DirectionRepositorie : Repositorie <Direction> ,IDirectionRepositorie
    {
    }
}