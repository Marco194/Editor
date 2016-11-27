using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorHtml
{
    public partial class PaginaIniziale : Form
    {
        public PaginaIniziale()
        {
            InitializeComponent();
        }

        private void PaginaIniziale_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Hide();
                new Form1().Show();
            }
        }

        private void checkBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Hide();
                new Attenzione().Show();
            }
        }
    }
}
