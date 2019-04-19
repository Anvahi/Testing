using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Окно_практика
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            Меню_для_студента newForm = new Меню_для_студента();
            newForm.Show();
        }

        private void Numbers_Click(object sender, EventArgs e)
        {

        }

        private void Test_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
