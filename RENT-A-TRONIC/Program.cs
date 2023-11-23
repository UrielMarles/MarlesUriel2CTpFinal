using BACK;
using RENT_A_TRONIC.FORMS;

namespace RENT_A_TRONIC
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // cambiar reaccion a excepciones
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(appException);
            Application.ThreadException += new ThreadExceptionEventHandler(threadException);

            ConexionConTabla conec = new ConexionConTabla("Data Source=DESKTOP-FT8QR65\\NEWSERVER; Initial Catalog=RENT-A-TRONICDB;Integrated Security=True");
            Application.Run(new FrmMenu(conec));

        }
        static void appException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            Application.Run(new FrmError(ex));
            Application.Exit();
            
        }
        static void threadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            Application.Run(new FrmError(ex));
            Application.Exit();
            
        }
    }

}