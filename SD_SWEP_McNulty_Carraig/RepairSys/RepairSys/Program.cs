using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairSys
{
    static class Program
    {
      
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            frmMainMenu MainMenu = new frmMainMenu();
            MainMenu.StartPosition = FormStartPosition.CenterScreen;

            frmAddPart addPart = new frmAddPart();
            Application.Run(MainMenu);
        }
    }
}
