using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACK.Entidades
{
    public class CantidadEntidad : InterfazEntidades
    {
        private int id;
        private bool activo;
        private int cantidad;
        private string nombre;

        public int Id { get { return id; }set { id = value; } }
        public string Nombre { get { return nombre; }set { nombre = value; } }
        public bool Activo { get { return activo; } set { activo = value; } }
        public int Cantidad { get {  return cantidad; }set { cantidad = value; } }
        public string NombreTabla { get { return "cantidades"; } }

        public CantidadEntidad() { }
        public CantidadEntidad(int id, bool activo, int cantidad, string nombre)
        {
            this.id = id;
            this.activo = activo;
            this.cantidad = cantidad;
            this.nombre = nombre;
        }

        public CantidadEntidad(Dictionary<string,string> dict) 
        { 
            CargarInfoDeDict(dict);
        }

        public void CargarInfoDeDict(Dictionary<string, string> dict)
        {
            this.id = int.Parse(dict["id"]);
            this.cantidad = int.Parse(dict["cantidad"]);
            this.activo = dict["activo"] == "True";
            this.nombre = dict["nombre"];
        }

        public Dictionary<string, string> DevolverInfoEnDict()
        {
            return new Dictionary<string, string>
            {
                ["id"] = this.id.ToString(),
                ["activo"] = this.activo ? "True" : "False",
                ["nombre"] = this.nombre,
                ["cantidad"] = this.cantidad.ToString(),
            };
        }
    }
}
