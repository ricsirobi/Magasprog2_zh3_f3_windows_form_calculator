using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szamologep
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();//tc92hl
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator());
        }
    }
}
