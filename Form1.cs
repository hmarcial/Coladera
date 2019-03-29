using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        Cola v = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btndale_Click(object sender, EventArgs e)
        {
            v.llenar();
            v.Compara();
            txtr.Text = v.ver();
        }
    }
}
