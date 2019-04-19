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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((Login.Text=="Студент")&&(Parol.Text=="123"))
            {
                Hide();
                Меню_для_студента newForm = new Меню_для_студента();
                newForm.Show();
                
            }
            if((Login.Text=="Преподаватель")&&(Parol.Text=="123"))
            {
                Hide();
                TeacherMenu newTeacherMenu = new TeacherMenu();
                newTeacherMenu.Show();

            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
