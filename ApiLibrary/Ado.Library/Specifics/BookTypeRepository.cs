using Models.Dtos;
using Models.Ado.Library;
using System.Collections.Generic;
using System.Linq;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Books
{
    public class BookTypeRepository : Repository<BookType,BookTypeDto>, IBookTypeRepository
    {
        public BookTypeRepository(string identificator= "IdType") : base(identificator)
        {

        }

        public new List<BookTypeDto> Get()
        {
            var list = dbSet.ToList();
            return mapper.Map<List<BookTypeDto>>(list);
        }

        public BookTypeDto GetByName(string name)
        {
            var list = dbSet.Where(w => w.TypeName.Equals(name)).FirstOrDefault();
            return mapper.Map<BookTypeDto>(list);
        }

        public List<BookTypeDto> SearchByName(string text)
        {
            var list = dbSet.Where(w => w.TypeName.Contains(text)).ToList();
            return mapper.Map<List<BookTypeDto>>(list);
        }

        public List<BookTypeDto> SearchByName(string text, int pag, int element)
        {
            var list = dbSet.Where(w => w.TypeName.Contains(text))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<BookTypeDto>>(list);
        }
    }
}