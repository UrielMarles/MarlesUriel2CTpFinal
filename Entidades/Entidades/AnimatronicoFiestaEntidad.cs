using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACK.Entidades
{
    public class AnimatronicoFiestaEntidad:InterfazEntidades
    {
        private int id;
        private bool activo;
        private int fiestaId;
        private int animatronicoId;

        public int Id { get { return id; } }
        public bool Activo { get { return activo; } set { activo = value; } }
        public int FiestaId {  get { return fiestaId; } }

        public int AnimatronicoId { get { return animatronicoId; } }
        public string NombreTabla { get { return "animatronicosFiestas"; } }


        public AnimatronicoFiestaEntidad() { }
        public AnimatronicoFiestaEntidad(int id, bool activo, int fiestaId, int animatronicoId)
        {
            this.id = id;
            this.activo = activo;
            this.fiestaId = fiestaId;
            this.animatronicoId = animatronicoId;
        }

        public AnimatronicoFiestaEntidad(Dictionary<string, string> dict)
        {
            CargarInfoDeDict(dict);
        }
        public void CargarInfoDeDict(Dictionary<string, string> dict)
        {
            this.id = int.Parse(dict["id"]);
            this.fiestaId = int.Parse(dict["fiestaId"]);
            this.animatronicoId = int.Parse(dict["animatronicoId"]);
            this.activo = dict["activo"] == "True";
        }

        public Dictionary<string, string> DevolverInfoEnDict()
        {
            return new Dictionary<string, string>
            {
                ["id"] = this.id.ToString(),
                ["activo"] = this.activo ? "True" : "False",
                ["fiestaId"] = this.fiestaId.ToString(),
                ["animatronicoId"] = this.AnimatronicoId.ToString(),
            };
        }
    }
}
