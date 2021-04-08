using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Genders;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Genders
{
    public class GenderRepositorie : Repository<Gender>, IGenderRepositorie
    {
        public GenderRepositorie(string identificator="IdGender") : base(identificator)
        {
        }

        public List<GenderDto> SearchByName(string text)
        {
            var list = dbSet.Where(w => w.GenderName.Contains(text)).ToList();
            return mapper.Map<List<GenderDto>>(list);
        }

        public List<GenderDto> SearchByName(string text, int pag, int element)
        {
            var list = dbSet.Where(w => w.GenderName.Contains(text))
                .OrderBy(w=> w.GenderName)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<GenderDto>>(list);
        }

        public new List<GenderDto> Get()
        {
            var list = dbSet.ToList();
            return mapper.Map<List<GenderDto>>(list);
        }

        public new List<GenderDto> Get(int element,int pag)
        {
            var list = dbSet
                .OrderBy(w => w.GenderName)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();

            return mapper.Map<List<GenderDto>>(list);
        }

    }
}