﻿using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Taxe
{
    public class TaxesRepository : Repository<Taxes,TaxesDto>, ITaxesRepository
    {
        public TaxesRepository(string identificator="IdTaxes") : base(identificator)
        {
        }

        public new dynamic Delete(List<string> ids)
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
                        message += Save();
                    }
                }
                else
                {
                    message += "Entity whith Id =" + id + " not was found";
                }
            }
            return message;
        }

        public List<Taxes> GetByType(int type)
        {
            return dbSet.Where(w => w.TaxType == type).ToList();
        }

        public List<Taxes> GetByType(int type, int pag, int element)
        {
            return dbSet.Where(w => w.TaxType == type)
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList(); 
        }

        public List<Taxes> SearchByName(string text)
        {
            return dbSet.Where(w => w.TaxTittle.Contains(text)).ToList();
        }

        public List<Taxes> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.TaxTittle.Contains(text))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList(); 
        }
    }
}