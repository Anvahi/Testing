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
        int choice;
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

        private void Cycles_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Arrays_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Strings_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Recursion_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Structs_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Files_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void Pointers_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void Dynamic_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                if (Cycles.Checked)
                    choice = 1;
                if (Arrays.Checked)
                    choice = 2;
                if (Strings.Checked)
                    choice = 3;
                if (Recursion.Checked)
                    choice = 4;
                if (Structs.Checked)
                    choice = 5;
                if (Files.Checked)
                    choice = 6;
                if (Pointers.Checked)
                    choice = 7;
                if (Dynamic.Checked)
                    choice = 8;
           
        }
    }
}
