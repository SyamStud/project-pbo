using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_pbo.Interface
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void sumberBtn_Click(object sender, EventArgs e)
        {
            SumberDana sumberDana = new SumberDana();

            sumberDana.TopLevel = false;
            contentPnl.Controls.Clear();
            contentPnl.Controls.Add(sumberDana);
            sumberDana.Show();
        }
    }
}