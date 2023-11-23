using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACK.Entidades
{
    public interface InterfazEntidades
    {
        public int Id { get; }
        public bool Activo { get; set; }
        public string NombreTabla { get; }

        public void CargarInfoDeDict(Dictionary<string, string> dict);

        public Dictionary<string, string> DevolverInfoEnDict();

        public void CrearEntradaEnLaTabla(ConexionConTabla cnH)
        {
            cnH.CargarNuevaFila(DevolverInfoEnDict(), NombreTabla);
        }
        public void ActualizarEntradaEnLaTabla(ConexionConTabla cnh)
        {
            cnh.CambiarInformacionFila(DevolverInfoEnDict(),NombreTabla);
        }
    }
}
