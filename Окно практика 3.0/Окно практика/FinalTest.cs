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
    public partial class FinalTest : Form
    {
        public FinalTest()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            Меню_для_студента newForm = new Меню_для_студента();
            newForm.Show();
        }

        private void FinalTest_Load(object sender, EventArgs e)
        {

        }

        private void FinalTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
