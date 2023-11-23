using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BACK.Entidades
{
    public static class MetodosConversion
    {
        public static List<Dictionary<string, string>> ConvertirCsv(this string ruta)
        {
            List<Dictionary<string, string>> lista = new List<Dictionary<string, string>>();
            using (StreamReader lector = new StreamReader(ruta))
            {
                string primeraLinea = lector.ReadLine();
                string[] nombresColumnas = primeraLinea.Split(',');

                while (!lector.EndOfStream)
                {
                    string filaTabla = lector.ReadLine();
                    if (filaTabla == null) { break; }

                    string[] valores = filaTabla.Split(',');
                    Dictionary<string, string> row = new Dictionary<string, string>();

                    for (int i = 0; i < nombresColumnas.Length; i++)
                    {
                        // Si la columna es "id", guarda "-1" en lugar del valor actual
                        if (nombresColumnas[i].ToLower() == "id")
                        {
                            row[nombresColumnas[i]] = "-1";
                        }
                        else
                        {
                            row[nombresColumnas[i]] = valores[i];
                        }
                    }

                    lista.Add(row);
                }
            }
            return lista;
        }

        public static void CrearCsv(this List<Dictionary<string, string>> lista, string ruta)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ExcepcionFilaNoEncontrada("La lista está vacía o es nula. No se creará ningún archivo CSV.");
            }

            string[] nombresColumnas = lista.First().Keys.ToArray();

            using (StreamWriter escritor = new StreamWriter(ruta))
            {
                escritor.WriteLine(string.Join(",", nombresColumnas));

                foreach (var fila in lista)
                {
                    var valores = nombresColumnas.Select(columna => fila[columna]);

                    escritor.WriteLine(string.Join(",", valores));
                }
            }
        }
        public static List<string> ListarErrores(this Exception ex)
        {
            List<string> lista = new List<string>();
            lista.Add($"Error principal: {ex.Message}");
            if (ex.InnerException != null)
            {
                int innerExceptionCount = 2;
                Exception innerException = ex.InnerException;
                while (innerException != null)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(($"Error {innerExceptionCount}: "));
                    sb.Append((innerException.Message));
                    innerException = innerException.InnerException;
                    innerExceptionCount++;
                    lista.Add(sb.ToString());
                }
            }
            return lista;

        }
        public static string StringifyErrores(this Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Error principal:");
            sb.Append((ex.Message));
            if (ex.InnerException != null)
            {
                int innerExceptionCount = 1;
                Exception innerException = ex.InnerException;
                while (innerException != null)
                {
                    sb.Append(($"Error interno {innerExceptionCount}:"));
                    sb.Append((innerException.Message));
                    innerException = innerException.InnerException;
                    innerExceptionCount++;
                }
            }
            return sb.ToString();

        }
        public static List<int> StringToIntList(string listaString)
        {
            string[] elementos = listaString.Split(';');
            List<int> listaDeEnteros = new List<int>();
            foreach (string elemento in elementos)
            {
                if (int.TryParse(elemento, out int entero))
                {
                    listaDeEnteros.Add(entero);
                }
                else
                {
                    throw new Exception();
                }
            }
            return listaDeEnteros;
        }

        public static string IntListToString(List<int> listaInt)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int entero in listaInt)
            {
                sb.Append(entero.ToString());
                sb.Append(';');
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }




    }
}
