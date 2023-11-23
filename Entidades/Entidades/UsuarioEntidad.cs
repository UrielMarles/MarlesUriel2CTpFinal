using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACK.Entidades
{
    public class UsuarioEntidad : InterfazEntidades
    {
        private int id;
        private string nombre;
        private string contrasenia;
        private bool esAdmin;
        private bool activo;
        private string telefono;
        private int cantidadVentas;

        public int Id{ get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public bool Activo { get { return activo; } set { activo = value; } }
        public bool EsAdmin { get { return esAdmin; } set { esAdmin = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public int CantidadVentas { get { return cantidadVentas; } set { cantidadVentas = value; } }
        public string Contrasenia { get { return contrasenia; } set { contrasenia = value; } }
        public string NombreTabla { get { return "usuarios"; } }

        public UsuarioEntidad() { }
        public UsuarioEntidad(int id, string nombre, string contrasenia, bool esAdmin, bool activo, string telefono, int cantidadVentas)
        {
            this.id = id;
            this.nombre = nombre;
            this.contrasenia = contrasenia;
            this.esAdmin = esAdmin;
            this.activo = activo;
            this.telefono = telefono;
            this.cantidadVentas = cantidadVentas;

        }
        public UsuarioEntidad(Dictionary<string, string> dict)
        {
            this.CargarInfoDeDict(dict);
        }

        public void CargarInfoDeDict(Dictionary<string, string> dict)
        {
            try
            {
                this.id = int.Parse(dict["id"]);
                this.nombre = dict["nombre"];
                this.activo = dict["activo"] == "True";
                this.cantidadVentas = int.Parse(dict["cantidadVentas"]);
                this.telefono = dict["telefono"];
                this.contrasenia = dict["contrasenia"];
                if (dict["esAdmin"] != "True" && dict["esAdmin"] != "False")
                {
                    throw new ExcepcionConstruyendoEntidad("valor de esAdmin no valido");
                }
                this.esAdmin = dict["esAdmin"] == "True";
            }
            catch (Exception e)
            {
                throw new ExcepcionConstruyendoEntidad("Error cargando la info del usuario", e);
            }
        }

        public Dictionary<string, string> DevolverInfoEnDict()
        {
            return new Dictionary<string, string>
            {
                {"id",this.id.ToString()},
                {"nombre",this.nombre},
                {"activo",this.activo ? "True" : "False"},
                {"esAdmin",this.esAdmin ? "True" : "False"},
                {"telefono",this.telefono },
                {"cantidadVentas",this.cantidadVentas.ToString()},
                {"contrasenia",this.contrasenia}
            };
        }


    }
}
