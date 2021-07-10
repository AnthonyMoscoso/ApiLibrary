using Core.DBAccess.Ado;
using Core.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Core.DataAccess.Specifics.Files
{
    public class FileTxtRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        public string _name;
        public IEnumerable<string> _columns;
        public string _identificator;
        public string[] vector_columnas;
        public char _separador;
        public Type _type;
        public string _connectionString;
        public string _FileDir;

        public FileTxtRepository(string connectionString, string identificator, char separador)
        {
            _name = typeof(TEntity).Name;
            _columns = GetColumns(typeof(TEntity));
            _identificator = identificator;
            _separador = separador;
            _type = typeof(TEntity);
            _connectionString = connectionString;
            _FileDir = $"{_connectionString}/{_name}.txt";

        }
        public int Count()
        {
            return ReadFile().Count();
        }

        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return ReadFile().AsQueryable().Count(predicate);
        }

        public dynamic Delete(IEnumerable<string> id)
        {
            throw new NotImplementedException();
        }

        public dynamic Delete(string id)
        {
            TEntity search = ReadFile().FirstOrDefault(w => _identificator.Equals(id));
            if (search != null)
            {
                ReadFile().ToList().Remove(search);
            }
            Save();
            return 0;
        }

        public IEnumerable<TEntity> Get()
        {
            return ReadFile();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return ReadFile().AsQueryable().Where(predicate);
        }

        public IEnumerable<TEntity> Get(int elements, int pag)
        {

            return ReadFile().AsQueryable().OrderBy(w => _identificator).Skip((pag - 1) * elements).Take(elements);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, int pag, int element, string order)
        {
            return ReadFile().AsQueryable().Where(predicate).OrderBy(w => order).Skip((pag - 1) * element).Take(element);
        }

        public IEnumerable<TEntity> GetOrderBy(string order)
        {
            return ReadFile().AsQueryable().OrderBy(w => order);
        }

        public IEnumerable<TEntity> GetOrderBy(int elements, int pag, string order)
        {

            return ReadFile().AsQueryable().OrderBy(w => order).Skip((pag - 1) * elements).Take(elements); ;
        }

        public IEnumerable<TEntity> GetOrderBy(Expression<Func<TEntity, bool>> predicate, string order)
        {
            return ReadFile().AsQueryable().Where(predicate).OrderBy(w => order); ;
        }

        public TEntity GetSingle(string id)
        {
            return ReadFile().AsQueryable().FirstOrDefault(w => _identificator.Equals(id));
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> predicate)
        {
            return ReadFile().AsQueryable().Where(predicate).FirstOrDefault(predicate);
        }

        public dynamic Insert(IEnumerable<TEntity> list)
        {
            List<TEntity> entities = ReadFile().ToList();

            foreach (TEntity entity in list)
            {
                TEntity search = entities.FirstOrDefault(w => w._Id.Equals(entity._Id));
                if (search == null)
                {
                    entities.Add(search);
                }

            }
            WriteFile(entities);
            Save();
            return entities;
        }

        public dynamic Insert(TEntity entity)
        {
            TEntity search = GetSingle(entity._Id);
            if (search == null)
            {

            }
            return search;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public dynamic Update(IEnumerable<TEntity> list)
        {
            throw new NotImplementedException();
        }

        public dynamic Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<string> GetColumns(Type type)
        {
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                yield return propertyInfo.Name;
            }

        }

        private IEnumerable<TEntity> ReadFile()
        {
            TEntity entity = new TEntity();
            if (!Directory.Exists(Path.GetFullPath("")))
            {
                Directory.CreateDirectory(Path.GetFullPath(""));

            }
            if (!File.Exists(Path.Combine()))
            {
                File.Create(Path.Combine()).Close();
            }
            StreamReader streamReader = new StreamReader(Path.Combine(_connectionString, _name));
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {

                string[] values = line.Split(';');
                List<string> columnDatas = _columns.ToList();
                for (int i = 0; i < _columns.Count(); i++)
                {
                    PropertyInfo property = typeof(TEntity).GetProperty(columnDatas[i]);
                    property.SetValue(entity, Convert.ChangeType(columnDatas[i], property.GetType()), null);
                }


            }

            streamReader.Close();


            yield return entity;



        }

        private void WriteFile(IEnumerable<TEntity> entities)
        {
            string url = $@"{_connectionString}\{_name}.txt";
            StreamWriter streamWriter = new StreamWriter(url);
            string line;
            List<string> columns = _columns.ToList();
            foreach (TEntity entity in entities)
            {
                line = typeof(TEntity).GetProperty(columns[0]).GetValue(entity).ToString();
                for (int i = 1; i < columns.Count(); i++)
                {
                    line += $"{_separador} {_type.GetProperty(columns[i]).GetValue(entity).ToString()}";
                }
                streamWriter.WriteLine(line);
            }
            streamWriter.Close();
        }
    }
}
