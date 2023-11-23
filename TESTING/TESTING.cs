using BACK;
using BACK.Entidades;
using BACK.Herramientas;
using BACK.Scripts;
using System.Data.SqlClient;

namespace TESTING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                ConexionConTabla conec = new ConexionConTabla("Data Source=DESKTOP-FT8QR65\\NEWSERVER; Initial Catalog=RENT-A-TRONICDB;Integrated Security=True");
                ColeccionEntidades<FiestaEntidad> prueba = new ColeccionEntidades<FiestaEntidad>(conec);
                FilesManager.ResetearTablas(conec);
                FilesManager.CargarInformacionBase(conec, new List<InterfazEntidades>() { new UsuarioEntidad(), new AnimatronicoEntidad(), new FiestaEntidad(), new CantidadEntidad(), new AnimatronicoFiestaEntidad() });
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StringifyErrores());
            }
        }

    }
}

/////PRUEBA RESETEADO TABLA

//ConexionConTabla conec = new ConexionConTabla("Data Source=DESKTOP-FT8QR65\\NEWSERVER; Initial Catalog=RENT-A-TRONICDB;Integrated Security=True");
//BaseDataLoader.ResetearTablas(conec);
//BaseDataLoader.CargarInformacionBase(conec, new List<InterfazEntidades>() { new UsuarioEntidad(), new AnimatronicoEntidad(), new FiestaEntidad(), new CantidadEntidad(), new AnimatronicoFiestaEntidad() });


////PRUEBA CREADO ANIMATRONICO:

//conexioncontabla conec = new conexioncontabla("data source=desktop-ft8qr65\\newserver; initial catalog=rent-a-tronicdb;integrated security=true");
//conexioncontabla.imprimirlistadict(conec.lecturacompleta("select * from animatronicos"));

//animatronicoentidad freddy = new animatronicoentidad(-1, "golden freddy", "es fachero", true, 1);

//freddy.CrearEntradaEnLaTabla(conec);



//// PRUEBA CREADO FIESTA:
//ConexionConTabla conec = new ConexionConTabla("Data Source=DESKTOP-FT8QR65\\NEWSERVER; Initial Catalog=RENT-A-TRONICDB;Integrated Security=True");
//FiestaEntidad fiesta = new FiestaEntidad("mi casa", -1, true, 1500, "Juan", "+54 9 11 4194 3821", "correo@hotmail.com", new DateTime(2023, 12, 1));

//fiesta.CrearEntradaEnLaTabla(conec);

