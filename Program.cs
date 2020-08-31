using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyApp
{
    public class MyForm : Form
    {
        public MyForm()
        {
            InitComponents();
        }

        private void InitComponents()
        {
            Text = "Simple Selector of STM32 ECU";
            ClientSize = new Size(1000, 700);
            CenterToScreen();
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.Run(new MyForm());
        }
    }
}
