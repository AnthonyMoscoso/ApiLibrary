using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class AutorDto
    {
        #region Atributes 
        public string IdAutor { get; set; }
        public string AutorName { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("Id : {0}\nName : {1}", IdAutor, AutorName);
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                AutorDto x = (AutorDto)obj;
                return (IdAutor == x.IdAutor);
            }
        }
        public override int GetHashCode()
        {
            return IdAutor.GetHashCode();
        }
        #endregion
    }
}