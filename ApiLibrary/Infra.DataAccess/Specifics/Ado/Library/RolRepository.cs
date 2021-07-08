using Models.Dtos;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;


namespace Ado.Library.Specifics
{
    public class RolRepository : AdoRepository<Rol>, IRolRepository
    {
        public RolRepository(BookStoreEntities context, string identificator = "IdRol") : base(context, identificator)
        {
        }
     /*   public new dynamic Update(List<Rol> list)
        {
            string message = "";
            foreach (Rol entity in list)
            {
                dbSet.Attach(entity);
                Context.Entry(entity).State = EntityState.Modified;
                message += Save();
                List<Permit>permitsInDB =Context.Permit.Where(w => w.Rol.Any(r => r.IdRol.Equals(entity.IdRol))).ToList();
                DeletePermit(permitsInDB,entity);
                InsertPermit(entity,permitsInDB);

            }
            return Save(); ; 
        }*/

      /*  private dynamic DeletePermit(List<Permit> list,Rol entity)
        {
            if (list.Count > 0)
            {

                List<PermitDto> permitDtoDb = mapper.Map<List<PermitDto>>(list);
                List<PermitDto> rolPermitDto = mapper.Map<List<PermitDto>>(entity.Permit);
                foreach (PermitDto permit in permitDtoDb)
                {
                    if (!rolPermitDto.Contains(permit))
                    {
                        list.Remove(mapper.Map<Permit>(permit));
                        var query = string.Format("Delete from RolPermit where idRol='{0}' AND idPermit='{1}';", entity.IdRol, permit.IdPermit);
                        Context.Database.ExecuteSqlCommand(query);
                    }
                }
                Save();
            }
        }*/

      /*  private dynamic InsertPermit(Rol entity,List<Permit> permitsInDB)
        {
            if (entity.Permit.Count > 0)
            {
                if (permitsInDB.Count > 0)
                {
                    List<PermitDto> permitDtoDb = mapper.Map<List<PermitDto>>(permitsInDB);
                    List<PermitDto> rolPermitDto = mapper.Map<List<PermitDto>>(entity.Permit);
                    foreach (PermitDto e in rolPermitDto)
                    {
                        if (!permitDtoDb.Contains(e))
                        {
                            var query = string.Format("Insert into RolPermit values ('{0}','{1}'); ", entity.IdRol, e.IdPermit);
                            Context.Database.ExecuteSqlCommand(@query);
                        }
                    }
                    Save();
                }
                else
                {
                    foreach (Permit e in entity.Permit)
                    {
                        var query = string.Format("Insert into RolPermit values ('{0}','{1}'); ", entity.IdRol, e.IdPermit);
                        Context.Database.ExecuteSqlCommand(query);
                    }
                    Save();

                }
            }
        }*/

       public new dynamic Delete(List<string> ids)
        {
            string message = string.Empty;
            foreach (string id in ids)
            {

                query = string.Format("Select * from {0} where {1}='{2}'", name, Identificator, id);
                Rol search = dbSet.Find(id); ;
                if (search != null)
                {
                    var query = string.Format("Delete from RolPermit where IdRol='{0}'",id);
                    base.ExecuteQuery(query);
                    dbSet.Remove(dbSet.Find(id));
            
                }
                else
                {
                    message += "Entity whith Id =" + id + " not was found";
                }
            }
            return Save();
           
        }

        public IEnumerable<Rol> SearchByName(string text)
        {
            return dbSet.Where(w => w.RolName.Contains(text));
        }

        public IEnumerable<Rol> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.RolName.Contains(text))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element);
        }
    }
}