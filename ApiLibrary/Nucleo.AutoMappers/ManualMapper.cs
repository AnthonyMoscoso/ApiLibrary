using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Nucleo.Mappers
{
    public class ManualMapper<TMapTo, TMapFrom> : IManualMapper<TMapTo, TMapFrom>
        where TMapTo : class, new()
        where TMapFrom : class, new()
    {

        /// <summary>
        /// Metodo para recoger nuestra entidad TMapTo desde la entidad TMapFrom que pasabamos por parametro
        /// </summary>
        /// <param name="mapFrom">entidad desde la que vamos a mapear</param>
        /// <returns>entidad mapeada</returns>
        public TMapTo Map(TMapFrom mapFrom)
        {
            Type T_Map = mapFrom.GetType();
            PropertyInfo[] props_map = T_Map.GetProperties();


            IDictionary<string, string> initial_dictionary = new Dictionary<string, string>();
            foreach (var n in props_map)
            {
                initial_dictionary.Add(n.Name, n.GetValue(mapFrom).ToString());
            }

            TMapTo mapTo = Mapping(initial_dictionary);
            return mapTo;
        }

        /// <summary>
        /// Metodo para recoger una collec
        /// </summary>
        /// <param name="mapFroms"></param>
        /// <returns></returns>
        public IEnumerable<TMapTo> Map(IEnumerable<TMapFrom> mapFroms)
        {

            // por cada entidad de nuestra lista la mapeamos a una nueva de lista de datos que queremos recoger 
            foreach (TMapFrom mapFrom in mapFroms)
            {
                // optenemos el tipo de dato  ejemplo Coche cocheNuevo : obtenemos el tipo Coche
                Type typeObjectToMap = mapFrom.GetType();

                // en un array de property info obtenemos las propiedad de nuestros objeto ej : color  -  rojo , km -12  en formato string
                PropertyInfo[] props_map = typeObjectToMap.GetProperties();


                // creamos nuestro diccionario donde insertamos los datos 
                IDictionary<string, string> initial_dictionary = new Dictionary<string, string>();
                foreach (PropertyInfo property in props_map)
                {
                    // optenemos el nombre de la proiedad , y el valor en caso de que lo tengo en caso de que no le damos por defecto null ???

                    initial_dictionary.Add(property.Name, property.GetValue(mapFrom)?.ToString());
                }

                // llamamos a nuestro  metodo privador para mapear desde el diccionario a nuestra nueva entidad 
                TMapTo mapTo = Mapping(initial_dictionary);

                // lo que realiza el Yield return es que el valor nos los añade a un IEnumerable ahorrandonos tener que crear una lista añadir los datos y devolverla luego
                yield return mapTo;
            }
        }

        /// <summary>
        /// Metodo privado al que le pasamos un diccionario con las clave valor,para crear un objeto nuevo y devolverlo
        /// </summary>
        /// <param name="source">Diccionario clave valor</param>
        /// <returns>Entidad mapeada desde el diccionario</returns>
        private TMapTo Mapping(IDictionary<string, string> source)
        {
            TMapTo someObject = new TMapTo();
            Type someObjectType = someObject.GetType();

            // recorremos los valores de nuestro diccionario 
            foreach (KeyValuePair<string, string> item in source)
            {
                if (someObjectType.GetProperty(item.Key) != null)
                {
                    someObjectType.GetProperty(item.Key)
                        .SetValue(someObject,
                        // Convert change type (le pasamos un valor , y lo convertimos al tipo indicado) , Convert.ChangeType("2",int) me convierte el 2 que viene en formato string  en un int
                        Convert.ChangeType(
                            // valor del nuestro diccionario ej : 2 
                            item.Value,

                            // valor de nuestra entidad con la clave  ej :  int cantidad  la clave es cantidad y el tipo int
                            someObjectType.GetProperty(item.Key).PropertyType), null);

                }
            }

            return someObject;
        }
    }
}
