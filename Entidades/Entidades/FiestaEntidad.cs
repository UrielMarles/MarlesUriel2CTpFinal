using BACK;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACK.Entidades
{
    public class FiestaEntidad : InterfazEntidades
    {
        private int id;
        private bool activo;
        private int precio;
        private string lugar;
        private string nombre;
        private string telefonoCliente;
        private string correoCliente;
        private int adminFiestaId;
        private DateTime fecha;

        public int Id { get { return id; } set { id = value; } }
        public bool Activo { get { return activo; } set { activo = value; } }
        public int Precio { get { return precio; } set { precio = value; } }
        public string Lugar { get { return lugar; } set { lugar = value; } }
        public string NombreCliente { get { return nombre; } set { nombre = value; } }
        public string TelefonoCliente { get { return telefonoCliente; } set { telefonoCliente = value; } }
        public string CorreoCliente { get { return correoCliente; } set { correoCliente = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public int AdminFiestaId { get { return adminFiestaId; } set { adminFiestaId = value; } }

        public string NombreTabla { get { return "fiestas"; } }

        public FiestaEntidad() { }
        public FiestaEntidad(string lugar,int id,bool activo,int precio, string nombre,string telefonoCliente,string correoCliente,DateTime fechaFiesta,int adminFiestaId)
        {
            //this.idsAnimatronicos = animatronicosId;
            this.id = id;
            this.activo = activo;
            this.lugar = lugar;
            this.precio = precio;
            this.nombre = nombre;
            this.telefonoCliente = telefonoCliente;
            this.correoCliente = correoCliente;
            this.fecha = fechaFiesta;
            this.adminFiestaId = adminFiestaId;
            ValidarValores();
        }

        public FiestaEntidad(Dictionary<string, string> dict)
        {
            CargarInfoDeDict(dict);
            ValidarValores();
        }

        public void CargarInfoDeDict(Dictionary<string, string> dict)
        {
            this.lugar = dict["lugar"];
            this.id = int.Parse(dict["id"]);
            this.activo = dict["activo"] == "True";
            this.precio = int.Parse(dict["precio"]);
            this.nombre = dict["nombre"];
            this.telefonoCliente = dict["telefonoCliente"];
            this.correoCliente = dict["correoCliente"];
            this.adminFiestaId = int.Parse(dict["adminFiestaId"]);
            this.fecha = DateTime.ParseExact(dict["fecha"], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
        }

        public Dictionary<string, string> DevolverInfoEnDict()
        {
            return new Dictionary<string, string>
            {
                ["id"] = this.id.ToString(),
                ["lugar"] = this.lugar,
                ["activo"] = this.activo ? "True" : "False",
                ["precio"] = this.precio.ToString(),
                ["nombre"] = this.nombre,
                ["telefonoCliente"] = this.telefonoCliente.ToString(),
                ["correoCliente"] = this.correoCliente,
                ["adminFiestaId"] = this.adminFiestaId.ToString(),
                ["fecha"] = this.fecha.ToString("yyyy-MM-dd")
            };
       
        }
        private void ValidarValores()
        {
            if (precio != 1000 && precio!=1500 && precio != 2000) 
            {
                throw new ExcepcionConstruyendoEntidad("Precio de fiesta invalido");
            }
        }

    }
}
//StringBuilder sb = new StringBuilder("DECLARE @MaximoID INT; SELECT @MaximoID = MAX(id) FROM fiestas;");
//foreach (int id in this.idsAnimatronicos)
//{
//    sb.Append("INSERT INTO  animatronicosFiesta (activo,fiestaId,animatronicoId,fechaFiesta) VALUES (1,@MaximoId, ");
//    sb.Append(id);
//    sb.Append(", '");
//    sb.Append(dict["fecha"]);
//    sb.Append("');");
//}
//cnH.Ejecutar(sb.ToString());