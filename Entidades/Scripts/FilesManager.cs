    using BACK.Entidades;
using BACK.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACK.Herramientas
{
    public static class FilesManager
    { 
        public static void ResetearTablas(ConexionConTabla connect)
        {
            string contenido;
            using (FileStream fs = new FileStream("D:\\UTN\\CUATRIDOS\\PROGRALABO\\INTEGRADOR2\\Entidades\\Data\\SQLreseteotablas.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    contenido = sr.ReadToEnd();
                }
            }
            connect.Ejecutar(contenido);
        }
        public static void CargarInformacionBase(ConexionConTabla cnc,List<InterfazEntidades> listaTablas)
        {
            foreach(InterfazEntidades entidad in listaTablas)
            {
                string nombre = entidad.NombreTabla;
                string rutaCsv = Path.Combine("D:\\UTN\\CUATRIDOS\\PROGRALABO\\INTEGRADOR2\\Entidades\\Data\\", $"{nombre}.csv");
                List<Dictionary<string, string>> listaFilasCsv = rutaCsv.ConvertirCsv();
                foreach(Dictionary<string,string> dict in listaFilasCsv)
                {
                    entidad.CargarInfoDeDict(dict);
                    entidad.CrearEntradaEnLaTabla(cnc);
                }
                Console.WriteLine(nombre + " se cargo correctamente");
            }
        }

        public static void GuardarUnBackup(List<List<Dictionary<string,string>>> listaTablas,List<string> nombresTablas)
        {
            string ruta = "D:\\UTN\\CUATRIDOS\\PROGRALABO\\INTEGRADOR2\\Entidades\\Backups\\";
            int nroBackup = 1;
            while (Directory.Exists($"{ruta}{nroBackup}"))
            {
                nroBackup++;
            }
            ruta = $"{ruta}{nroBackup}\\";
            Directory.CreateDirectory(ruta);
            int indiceTabla = 0;
            foreach (List<Dictionary<string, string>> tabla in listaTablas)
            {
                tabla.CrearCsv($"{ruta}{nombresTablas[indiceTabla]}.csv");
                indiceTabla++;
            }
        }
    }
}
