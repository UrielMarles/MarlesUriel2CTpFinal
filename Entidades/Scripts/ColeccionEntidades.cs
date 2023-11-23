using BACK.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BACK.Scripts
{
    public class ColeccionEntidades<T> where T : InterfazEntidades,new()
    {
        private List<T> lista;
        public List<T> ListaT { get { return lista; } }
        public ConexionConTabla cnc;
        public ColeccionEntidades(List<T> lista, ConexionConTabla cnc)
        {
            this.lista = lista;
            this.cnc = cnc;
        }

        public ColeccionEntidades(ConexionConTabla cnc,bool soloActivos) 
        {
            this.cnc = cnc;
            LlenarColeccionConLaTabla();
            if (soloActivos) 
            {
                this.lista = FiltrarActivos();
            }
            
        }

        public ColeccionEntidades(ConexionConTabla cnc) : this(cnc, true) { }

        public void LlenarColeccionConLaTabla()
        {
            T entidadVacia = new T();
            this.lista = new List<T>();
            List<Dictionary<string, string>> listaDicts = this.cnc.LecturaCompleta($"SELECT * FROM {entidadVacia.NombreTabla}");
            foreach (Dictionary<string, string> dict in listaDicts)
            {
                T nuevaEntidad = new T();
                nuevaEntidad.CargarInfoDeDict(dict);
                this.lista.Add(nuevaEntidad);
            }
        }

        //filtra de su coleccion las entidades que no esten activas
        public List<T> FiltrarActivos()
        {
            List<T> retorna = new List<T>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Activo)
                {
                    retorna.Add(lista[i]);
                }
            }
            return retorna;
        }

        public List<T> NombreContieneString(string contiene)
        {
            Regex regex = new Regex(contiene, RegexOptions.IgnoreCase);
            List<T> retorna = new List<T>();
            foreach (T t in lista)
            {
                Dictionary<string,string> dict = t.DevolverInfoEnDict();
                if (regex.IsMatch(dict["nombre"]))
                {
                    retorna.Add(t);
                }
            }
            return retorna;
        }
        public T ObtenerPorId(int id)
        {
            foreach(T t in lista)
            {
                if (t.Id == id)
                { 
                    return t; 
                }    
            }
            throw new ExcepcionFilaNoEncontrada("La fila con el id no estaba dentro de la coleccion");
        }

        //Filtra de su coleccion las entidades que no tengan un valor en una llave
        public List<T> EntidadesConValorEnLLave(string llave,string valor)
        {
            List<T >retorna = new List<T>();
            for (int i = 0; i < lista.Count; i++)
            {
                Dictionary<string, string> dict = lista[i].DevolverInfoEnDict();
                if (dict.ContainsKey(llave) && dict[llave] == valor)
                {
                    retorna.Add(lista[i]);
                }
            }
            return retorna;
        }
        public List<T> this[string llave,string valor]
        {
            get
            {
                return EntidadesConValorEnLLave(llave,valor);
            }
        }

        public static string CrearCadenaDesdeDiccionario(Dictionary<string, string> diccionario)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var kvp in diccionario)
            {
                // Agrega la clave y el valor al StringBuilder
                sb.Append($"{kvp.Key}: {kvp.Value}, ");
            }

            // Elimina la coma y el espacio adicionales al final de la cadena
            if (sb.Length >= 2)
            {
                sb.Length -= 2;
            }

            return sb.ToString();
        }

    }
}
