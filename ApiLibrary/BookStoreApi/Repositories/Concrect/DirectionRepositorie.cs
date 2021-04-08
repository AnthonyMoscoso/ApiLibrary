using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Directions;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Directions
{
    public class DirectionRepositorie : Repository<Direction>, IDirectionRepositorie
    {
        public DirectionRepositorie(string identificator="IdDirection") : base(identificator)
        {
        }

        public new List<DirectionDto> Get()
        {
            var list = dbSet.ToList();
            return mapper.Map<List<DirectionDto>>(list);
        }
    }
}