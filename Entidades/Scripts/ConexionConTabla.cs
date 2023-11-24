using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Net.Security;
using System.Text;

namespace BACK
{
    
    public class ConexionConTabla
    {

        public SqlConnection cnct;

        public ConexionConTabla(string connectionString)
        {
            this.cnct = new SqlConnection(connectionString);
        }

        public bool FuncionaConexion
        {
            get
            {
                try
                {
                    cnct.Open();
                    cnct.Close();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Ejecuta una consulta SQL proporcionada como cadena y devuelve los resultados en forma de lista de diccionarios.
        /// </summary>
        /// <param name="comandoString">Cadena SQL que representa la consulta a ejecutar.</param>
        /// <returns>Lista de diccionarios que representan las filas y columnas resultantes de la consulta.</returns>
        /// <exception cref="ExcepcionQueryFallida">Se produce si la consulta no puede ejecutarse correctamente o si se encuentra un valor nulo en la tabla.</exception>
        public List<Dictionary<string,string>> LecturaCompleta(string comandoString)
        {
            try
            {
                SqlCommand comandoObjeto = new SqlCommand();
                comandoObjeto.CommandType = System.Data.CommandType.Text;
                comandoObjeto.CommandText = comandoString;
                comandoObjeto.Connection = this.cnct;
                this.cnct.Open();
                SqlDataReader lector = comandoObjeto.ExecuteReader();
                List<Dictionary<string, string>> devuelve = new List<Dictionary<string, string>>();
                while (lector.Read())
                {
                    Dictionary<string, string> fila = new Dictionary<string, string>();
                    for (int i = 0; i < lector.FieldCount; i++)
                    {
                        string valorCampo;
                        string nombreCampo = lector.GetName(i);
                        if (lector[i] == DBNull.Value)
                        {
                            throw new ExcepcionQueryFallida("Valor nulo en la tabla");
                        }
                        valorCampo = lector[i].ToString();
                        if(typeof(DateTime) == lector[i].GetType())
                        {
                            valorCampo = ((DateTime)lector[i]).ToString("yyyy-MM-dd");
                        }
                        fila[nombreCampo] = valorCampo;
                    }
                    devuelve.Add(fila);
                }
                this.cnct.Close();
                return devuelve;
            }
            catch (ExcepcionQueryFallida)
            {
                throw;
            }
            catch(Exception ex) 
            {
                throw new ExcepcionQueryFallida("No se pudo realizar la consulta a la tabla",ex);
            }
        }

        public void Ejecutar(string comando)
        {
            try
            {
                SqlCommand comandoObjeto = new SqlCommand(comando, this.cnct);
                this.cnct.Open();
                comandoObjeto.ExecuteNonQuery();
                this.cnct.Close();
            }catch(Exception ex)
            {
                throw new ExcecpcionEjecutandoComandoSql("no se pudo ejecutar el comando sql",ex);
            }

        }

        /// <summary>
        /// Carga una nueva fila en la tabla especificada utilizando un diccionario de valores.
        /// </summary>
        /// <param name="dic">Diccionario que contiene los valores de la nueva fila.</param>
        /// <param name="tabla">Nombre de la tabla en la que se desea cargar la nueva fila.</param>
        /// <exception cref="ExcecpcionEjecutandoComandoSql">Se produce cuando el diccionario contiene una clave "id" con un valor distinto de "-1".</exception>
        public void CargarNuevaFila(Dictionary<string, string> dic,string tabla) 
        {
            if(dic.ContainsKey("id")) 
            {
                if (dic["id"] == "-1")
                {
                    dic.Remove("id");
                }
                else
                {
                    throw new ExcecpcionEjecutandoComandoSql("Para cargar una nueva columna el id especificado debe ser -1");
                }
            }
            StringBuilder sb = new StringBuilder($"INSERT INTO {tabla} (");
            foreach(KeyValuePair<string, string> kvp in dic)
            {
                sb.Append(kvp.Key);
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append(") VALUES (");
            foreach (KeyValuePair<string, string> kvp in dic)
            {
                sb.Append($"'{kvp.Value}'");
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append(");");
            string cargaTraducida = sb.ToString();
            this.Ejecutar(cargaTraducida);
        }

        /// <summary>
        /// Actualiza la información de una fila en la tabla especificada con los nuevos valores proporcionados en un diccionario.
        /// </summary>
        /// <param name="dic">Diccionario que contiene los nuevos valores a actualizar en la fila.</param>
        /// <param name="tabla">Nombre de la tabla en la que se desea realizar la actualización.</param>
        /// <exception cref="ExcecpcionEjecutandoComandoSql">
        /// Se produce si la id especificada en el diccionario es igual a -1,
        /// o si no se proporciona una id para identificar la fila a actualizar.
        /// </exception>
        public void CambiarInformacionFila(Dictionary<string, string> dic, string tabla)
        {
            string id;
            if (dic.ContainsKey("id"))
            {
                if (dic["id"] == "-1")
                {
                    throw new ExcecpcionEjecutandoComandoSql("Para actualizar una fila la id debe ser distinta a -1");
                }
            }
            else
            {
                throw new ExcecpcionEjecutandoComandoSql("Se debe indicar el id para poder actualizar la fila");
            }
            id = dic["id"];
            dic.Remove("id");
            StringBuilder sb = new StringBuilder($"UPDATE {tabla} SET ");
            foreach(KeyValuePair <string, string> kvp in dic)
            {
                sb.Append(kvp.Key);
                sb.Append(" = '");
                sb.Append(kvp.Value);
                sb.Append("', ");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append($" WHERE id = {id}");
            string cargaTraducida = sb.ToString();
            this.Ejecutar(cargaTraducida);
        }
    }
}