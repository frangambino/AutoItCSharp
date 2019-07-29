using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;

namespace FormularioAutoIt
{
    public partial class Form1 : Form
    {
        AutoItX3 auto = new AutoItX3();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auto.Run("notepad.exe", "", 1);
            auto.WinWaitActive("Untitled -", "", 1);
            auto.Send("Esto es una prueba");
            auto.Sleep(200);
            auto.Send("!f");
            auto.Send("{DOWN 3}");
            auto.Send("{ENTER}");
            auto.Sleep(500);
            auto.Send(string.Format("C:\\Temp\\archivo{0}{1}{2}{3}{4}{5}.txt",DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second));
            auto.Sleep(1000);
            auto.Send("{ENTER}");
            
            auto.Send("!{F4}");

        }
    }
}
