    using BACK.Entidades;
using BACK.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BACK.Herramientas
{
    public static class FilesManager
    { 
        public static string RutaPadreDesdeFront
        {
            get
            {
                string st = Directory.GetCurrentDirectory();
                string patron = @"^(.*\\RENT-A-TRONIC\\)";
                Regex regex = new Regex(patron);
                Match match = regex.Match(st);
                string pathHastaCarpeta = match.Groups[1].Value;
                string nuevaCadena = pathHastaCarpeta.Substring(0, pathHastaCarpeta.Length - 14);
                return nuevaCadena;
            }
                                

    }
    public static void ResetearTablas(ConexionConTabla connect)
        {
            string contenido;
            using (FileStream fs = new FileStream($"{RutaPadreDesdeFront}Entidades\\Data\\SQLreseteotablas.txt", FileMode.Open))
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
                string rutaCsv = Path.Combine($"{RutaPadreDesdeFront}Entidades\\Data\\", $"{nombre}.csv");
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
            string ruta = $"{RutaPadreDesdeFront}Entidades\\Backups\\";
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
