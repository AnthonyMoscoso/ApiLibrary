using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;


namespace Ado.Library.Specifics
{
    public class TaxesRepository : AdoRepository<Taxes>, ITaxesRepository
    {
        public TaxesRepository(BookStoreEntities context, string identificator="IdTaxes") : base(context,identificator)
        {
        }

          public new dynamic Delete(IEnumerable<string> ids)
           {
               string message = "";
               foreach (string id in ids)
               {
                   Taxes search = dbSet.Find(id);
                   if (search!=null)
                   {
                       if (search.PayRoll.Count>0)
                       {
                          string n= string.Format("Can delete Taxes {0}  is using by any Payroll, delete first all Payroll that has been related for delete",search.TaxTittle);
                           message += n;
                       }
                       else
                       {
                           dbSet.Remove(search);
                         
                       }
                   }
                   else
                   {
                       message += "Entity whith Id =" + id + " not was found";
                   }
               }
               Save();
            return ids;
              
           }

        public IEnumerable<Taxes> GetByType(int type)
        {
            return dbSet.Where(w => w.TaxType == type);
        }

        public IEnumerable<Taxes> GetByType(int type, int pag, int element)
        {
            return dbSet.Where(w => w.TaxType == type).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
        }

        public IEnumerable<Taxes> SearchByName(string text)
        {
            return dbSet.Where(w => w.TaxTittle.Contains(text));
        }

        public IEnumerable<Taxes> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.TaxTittle.Contains(text)).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
        }
    }
}