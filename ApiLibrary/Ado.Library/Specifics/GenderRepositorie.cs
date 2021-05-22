using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Genders
{
    public class GenderRepositorie : Repository<Gender,GenderDto>, IGenderRepositorie
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