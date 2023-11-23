
namespace BACK.Entidades
{
    public class AnimatronicoEntidad : InterfazEntidades
    {
        private int id;
        private string nombre;
        private string descripcion;
        private bool activo;
        private int cantidadAlmas;
        private int creadoPorId;

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public bool Activo { get { return activo; } set { activo = value; } }
        public int CantidadAlmas { get { return cantidadAlmas; } set { cantidadAlmas = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int CreadoPorId { get { return creadoPorId; } set { creadoPorId = value; } }
        public string NombreTabla { get { return "animatronicos"; } }
        public AnimatronicoEntidad(Dictionary<string, string> dict)
        {
            this.CargarInfoDeDict(dict);
        }
        public AnimatronicoEntidad() { }
        public AnimatronicoEntidad(int id, string nombre, string descripcion, bool activo, int cantidadAlmas, int creadoPorId)
        {
            this.id = id;
            this.nombre = nombre;
            this.activo = activo;
            this.cantidadAlmas = cantidadAlmas;
            this.descripcion = descripcion;
            this.creadoPorId = creadoPorId;
        }

        public void CargarInfoDeDict(Dictionary<string, string> dict)
        {
            try
            {
                this.id = int.Parse(dict["id"]);
                this.nombre = dict["nombre"];
                this.activo = dict["activo"] == "True";
                this.cantidadAlmas = int.Parse(dict["cantidadAlmas"]);
                this.descripcion = dict["descripcion"];
                this.creadoPorId = int.Parse(dict["creadoPorId"]);
            }
            catch (Exception e)
            {
                throw new ExcepcionConstruyendoEntidad("Error creando la entidad de un animatronico", e);
            }
        }
        public Dictionary<string, string> DevolverInfoEnDict()
        {
            return new Dictionary<string, string>
            {
                {"id",this.id.ToString()},
                {"nombre",this.nombre},
                {"activo",this.activo ? "True" : "False"},
                {"cantidadAlmas",this.cantidadAlmas.ToString()},
                {"descripcion",this.descripcion},
                {"creadoPorId",this.creadoPorId.ToString()}
            };
        }
    }
}
