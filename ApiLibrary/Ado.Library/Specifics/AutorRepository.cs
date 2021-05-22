using Models.Ado.Library;
using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace LibraryApiRest.Repositories.Concrect
{
    public class AutorRepository : Repository<Autor,AutorDto>, IAutorRepository
    {
        public AutorRepository(string identificator="IdAutor") : base(identificator)
        {
        }

    
        public bool ExistName(string name)
        {
            var result =dbSet.Where(W => W.AutorName.Equals(name)).SingleOrDefault();
            if (result!=null)
            {
               return true;
            }
            return false;
        }

        public AutorDto GetByName(string name)
        {
            var result = dbSet.Where(w => w.AutorName.Equals(name)).SingleOrDefault();
            return mapper.Map<AutorDto>(result);
        }

        public List<AutorDto> SearchByName(string text)
        {
            var result= dbSet.Where(w => w.AutorName.Contains(text)).ToList();
            return mapper.Map<List<AutorDto>>(result);
        }

        public List<AutorDto> SearchByName(string text, int pag, int element)
        {
            var result= dbSet.Where(w => w.AutorName.Contains(text))
                .OrderBy(w=> w.AutorName)
                .Skip((pag-1)*element)
                .Take(element).ToList();
            return mapper.Map<List<AutorDto>>(result);
        }
    }
}