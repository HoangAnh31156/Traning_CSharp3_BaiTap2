using TrainingCSharp3_BT2.Views;

namespace TrainingCSharp3_BT2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        // 
        //  
        // 
        // Scaffold-DbContext 'Data Source=DESKTOP-B52SRBN\SQLEXPRESS;Initial Catalog=TRAININGCSHARP3_BTAP2;Integrated Security=True; TrustServerCertificate=true' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context DBContext -Contextdir Context -DataAnnotations -Force

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize(); 
            Application.Run(new FrmSach()); 
        }
    }
}