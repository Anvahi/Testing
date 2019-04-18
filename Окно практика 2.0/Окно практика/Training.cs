using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Окно_практика
{
    public partial class Training : Form
    {
        public Training()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*XmlDocument xTraining = new XmlDocument();
            xTraining.Load("testing.xml");

            if (Cycles.Checked==true)
            {
                Question.Text=
            }
            if (Arrays.Checked == true)
            if (Strings.Checked == true)
            if (Recursion.Checked == true)
            if (Structs.Checked == true)
            if (Files.Checked == true)
            if (Pointers.Checked == true)
            if (Dynamic.Checked == true)*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Меню_для_студента newForm = new Меню_для_студента();
            newForm.Show(); 
        }

        private void Training_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
