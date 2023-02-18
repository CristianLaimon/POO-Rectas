using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Form2 : Form
    {
        private static Form2 instancia = null;
        public Form2()
        {
            InitializeComponent();
        }

        public static Form2 INSTANCIA
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Form2();
                }
                return instancia;
            }
        }


        private void Form2_Load(object sender, EventArgs e)
            
        {

        }
    }
}
