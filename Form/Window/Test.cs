﻿using System;
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
    public partial class Test : Form
    {
        int choice;
        int anser;
        int tru;
        int summ_tru;
        int[] rrand = new int[10];
        int p = 1;
        int[] summ_false = new int[10];
        int flag_3=1;

        public Test()
        {
            InitializeComponent();       
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            Меню_для_студента newForm = new Меню_для_студента();
            newForm.Show();
            flag_3 = 1;
        }

        private void Numbers_Click(object sender, EventArgs e)
        {
            Numbers.Text = " ";
            for(int i=0;i<10;i++)
            {
                if (summ_false[i]>0)
                {
                    Numbers.Text = Numbers.Text + "," + Convert.ToString(summ_false[i]);
                }
            }           
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
            while (flag_3 == 1)
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
            
            if (choice > 0)
                {
                    int flag_1 = 0;
                    int j, k;
                    int prov;
                    p = 1;
                    summ_tru = 0;
                    Rate.Text = "0";
                    CountMistake.Text = "0";
                    Numbers.Text = " ";
                    for (int i = 0; i < 10; i++)
                    {
                        summ_false[i] = 0;
                    }

                    Random rnd = new Random();
                    int arra_1;
                    int arra_2;

                    int[] array = new int[8];
                    int count = 0;

                    XmlDocument xDooc = new XmlDocument();
                    xDooc.Load("testing.xml");
                    XmlElement xRooot = xDooc.DocumentElement;

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load("testing.xml");
                    XmlElement xRoot = xDoc.DocumentElement;

                    foreach (XmlNode xnode in xRooot)
                    {
                        if (xnode.Name == "cycles")
                        {
                            foreach (XmlNode childcycles in xnode.ChildNodes)
                                count++;
                            array[0] = count;
                        }
                        else if (xnode.Name == "arrays")
                        {
                            foreach (XmlNode childarrays in xnode.ChildNodes)
                                count++;
                            array[1] = count;
                        }
                        else if (xnode.Name == "lines")
                        {
                            foreach (XmlNode childlines in xnode.ChildNodes)
                                count++;
                            array[2] = count;
                        }
                        else if (xnode.Name == "recursion")
                        {
                            foreach (XmlNode childrecursion in xnode.ChildNodes)
                                count++;
                            array[3] = count;
                        }
                        else if (xnode.Name == "struct")
                        {
                            foreach (XmlNode childstruct in xnode.ChildNodes)
                                count++;
                            array[4] = count;
                        }
                        else if (xnode.Name == "file")
                        {
                            foreach (XmlNode childfile in xnode.ChildNodes)
                                count++;
                            array[5] = count;
                        }

                        else if (xnode.Name == "addresses_and_pointers")
                        {
                            foreach (XmlNode childaddresses_and_pointers in xnode.ChildNodes)
                                count++;
                            array[6] = count;
                        }
                        else
                        {
                            foreach (XmlNode childdynamic_memory in xnode.ChildNodes)
                                count++;
                            array[7] = count;
                        }
                        count = 0;
                    }

                    switch (choice)
                    {
                        case 1:
                            {
                                arra_1 = 1;
                                arra_2 = array[0];
                                flag_1 = 0;
                                for (int i = 0; i < 10; i++)
                                {
                                    rrand[i] = rnd.Next(arra_1, arra_2);
                                    //Console.WriteLine(rrand[i]);
                                }

                                do
                                {
                                    j = 1; k = 0;
                                    prov = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] == rrand[j])
                                            {
                                                rrand[i] = rnd.Next(arra_1, arra_2);
                                            }
                                            j++;
                                        }
                                        k++;
                                    }

                                    j = 1; k = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] != rrand[j])
                                            {
                                                prov++;
                                            }
                                            j++;
                                        }
                                        k++;
                                    }
                                    if (prov == 45) flag_1 = 1;
                                } while (flag_1 != 1);
                                /*for (int i = 0; i < 10; i++)
                                {
                                    Console.WriteLine(rrand[i]);
                                }*/
                            }

                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "cycles")
                                {
                                    foreach (XmlNode childcycles in xnode.ChildNodes)
                                    {
                                        if (childcycles.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childcycles.Attributes.GetNamedItem("id");
                                            for (int i = 0; i < 1; i++)
                                            {
                                                int atrib;
                                                atrib = Convert.ToInt32(attr.Value);
                                                if (atrib == rrand[0])
                                                {
                                                    if (childcycles.Name == "question")
                                                    {
                                                        foreach (XmlNode childquestion in childcycles.ChildNodes)
                                                        {
                                                            if (childquestion.Name == "quest")
                                                            {
                                                                Question.Text = childquestion.InnerText;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        case 2:
                            {
                                arra_1 = 1 + array[0];
                                arra_2 = array[0] + array[1];
                                flag_1 = 0;
                                for (int i = 0; i < 10; i++)
                                {
                                    rrand[i] = rnd.Next(arra_1, arra_2);
                                    //Console.WriteLine(rrand[i]);                        
                                }

                                do
                                {
                                    j = 1; k = 0;
                                    prov = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] == rrand[j])
                                            {
                                                rrand[i] = rnd.Next(arra_1, arra_2);
                                            }
                                            j++;
                                        }
                                        k++;
                                    }

                                    j = 1; k = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] != rrand[j])
                                            {
                                                prov++;
                                            }
                                            j++;
                                        }
                                        k++;
                                    }
                                    if (prov == 45) flag_1 = 1;
                                } while (flag_1 != 1);
                                /*for (int i = 0; i < 10; i++)
                                {
                                    Console.WriteLine(rrand[i]);
                                }*/
                            }

                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "arrays")
                                {
                                    foreach (XmlNode childarrays in xnode.ChildNodes)
                                    {
                                        if (childarrays.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childarrays.Attributes.GetNamedItem("id");
                                            for (int i = 0; i < 1; i++)
                                            {
                                                int atrib;
                                                atrib = Convert.ToInt32(attr.Value);
                                                if (atrib == rrand[0])
                                                {
                                                    if (childarrays.Name == "question")
                                                    {
                                                        foreach (XmlNode childquestion in childarrays.ChildNodes)
                                                        {
                                                            if (childquestion.Name == "quest")
                                                            {
                                                                Question.Text = childquestion.InnerText;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        case 3:
                            {
                                arra_1 = 1 + array[0] + array[1];
                                arra_2 = array[0] + array[1] + array[2];
                                flag_1 = 0;
                                for (int i = 0; i < 10; i++)
                                {
                                    rrand[i] = rnd.Next(arra_1, arra_2);
                                    //Console.WriteLine(rrand[i]);
                                }

                                do
                                {
                                    j = 1; k = 0;
                                    prov = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] == rrand[j])
                                            {
                                                rrand[i] = rnd.Next(arra_1, arra_2);
                                            }
                                            j++;
                                        }
                                        k++;
                                    }

                                    j = 1; k = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] != rrand[j])
                                            {
                                                prov++;
                                            }
                                            j++;
                                        }
                                        k++;
                                    }
                                    if (prov == 45) flag_1 = 1;
                                } while (flag_1 != 1);
                                /*for (int i = 0; i < 10; i++)
                                {
                                    Console.WriteLine(rrand[i]);
                                }*/
                            }

                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "lines")
                                {
                                    foreach (XmlNode childlines in xnode.ChildNodes)
                                    {
                                        if (childlines.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childlines.Attributes.GetNamedItem("id");
                                            for (int i = 0; i < 1; i++)
                                            {
                                                int atrib;
                                                atrib = Convert.ToInt32(attr.Value);
                                                if (atrib == rrand[0])
                                                {
                                                    if (childlines.Name == "question")
                                                    {
                                                        foreach (XmlNode childquestion in childlines.ChildNodes)
                                                        {
                                                            if (childquestion.Name == "quest")
                                                            {
                                                                Question.Text = childquestion.InnerText;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        case 4:
                            {
                                arra_1 = 1 + array[0] + array[1] + array[2];
                                arra_2 = array[0] + array[1] + array[2] + array[3];
                                flag_1 = 0;
                                for (int i = 0; i < 10; i++)
                                {
                                    rrand[i] = rnd.Next(arra_1, arra_2);
                                    //Console.WriteLine(rrand[i]);
                                }

                                do
                                {
                                    j = 1; k = 0;
                                    prov = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] == rrand[j])
                                            {
                                                rrand[i] = rnd.Next(arra_1, arra_2);
                                            }
                                            j++;
                                        }
                                        k++;
                                    }

                                    j = 1; k = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] != rrand[j])
                                            {
                                                prov++;
                                            }
                                            j++;
                                        }
                                        k++;
                                    }
                                    if (prov == 45) flag_1 = 1;
                                } while (flag_1 != 1);
                                /*for (int i = 0; i < 10; i++)
                                {
                                    Console.WriteLine(rrand[i]);
                                }*/
                            }

                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "recursion")
                                {
                                    foreach (XmlNode childrecursion in xnode.ChildNodes)
                                    {
                                        if (childrecursion.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childrecursion.Attributes.GetNamedItem("id");
                                            for (int i = 0; i < 1; i++)
                                            {
                                                int atrib;
                                                atrib = Convert.ToInt32(attr.Value);
                                                if (atrib == rrand[0])
                                                {
                                                    if (childrecursion.Name == "question")
                                                    {
                                                        foreach (XmlNode childquestion in childrecursion.ChildNodes)
                                                        {
                                                            if (childquestion.Name == "quest")
                                                            {
                                                                Question.Text = childquestion.InnerText;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        case 5:
                            {
                                arra_1 = 1 + array[0] + array[1] + array[2] + array[3];
                                arra_2 = array[0] + array[1] + array[2] + array[3] + array[4];
                                flag_1 = 0;
                                for (int i = 0; i < 10; i++)
                                {
                                    rrand[i] = rnd.Next(arra_1, arra_2);
                                    //Console.WriteLine(rrand[i]);
                                }

                                do
                                {
                                    j = 1; k = 0;
                                    prov = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] == rrand[j])
                                            {
                                                rrand[i] = rnd.Next(arra_1, arra_2);
                                            }
                                            j++;
                                        }
                                        k++;
                                    }

                                    j = 1; k = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] != rrand[j])
                                            {
                                                prov++;
                                            }
                                            j++;
                                        }
                                        k++;
                                    }
                                    if (prov == 45) flag_1 = 1;
                                } while (flag_1 != 1);
                                /*for (int i = 0; i < 10; i++)
                                {
                                    Console.WriteLine(rrand[i]);
                                }*/
                            }

                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "struct")
                                {
                                    foreach (XmlNode childstruct in xnode.ChildNodes)
                                    {
                                        if (childstruct.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childstruct.Attributes.GetNamedItem("id");
                                            for (int i = 0; i < 1; i++)
                                            {
                                                int atrib;
                                                atrib = Convert.ToInt32(attr.Value);
                                                if (atrib == rrand[0])
                                                {
                                                    if (childstruct.Name == "question")
                                                    {
                                                        foreach (XmlNode childquestion in childstruct.ChildNodes)
                                                        {
                                                            if (childquestion.Name == "quest")
                                                            {
                                                                Question.Text = childquestion.InnerText;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        case 6:
                            {
                                arra_1 = 1 + array[0] + array[1] + array[2] + array[3] + array[4];
                                arra_2 = array[0] + array[1] + array[2] + array[3] + array[4] + array[5];
                                flag_1 = 0;
                                for (int i = 0; i < 10; i++)
                                {
                                    rrand[i] = rnd.Next(arra_1, arra_2);
                                    //Console.WriteLine(rrand[i]);
                                }

                                do
                                {
                                    j = 1; k = 0;
                                    prov = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] == rrand[j])
                                            {
                                                rrand[i] = rnd.Next(arra_1, arra_2);
                                            }
                                            j++;
                                        }
                                        k++;
                                    }

                                    j = 1; k = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] != rrand[j])
                                            {
                                                prov++;
                                            }
                                            j++;
                                        }
                                        k++;
                                    }
                                    if (prov == 45) flag_1 = 1;
                                } while (flag_1 != 1);
                                /*for (int i = 0; i < 10; i++)
                                {
                                    Console.WriteLine(rrand[i]);
                                }*/
                            }

                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "file")
                                {
                                    foreach (XmlNode childfile in xnode.ChildNodes)
                                    {
                                        if (childfile.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childfile.Attributes.GetNamedItem("id");
                                            for (int i = 0; i < 1; i++)
                                            {
                                                int atrib;
                                                atrib = Convert.ToInt32(attr.Value);
                                                if (atrib == rrand[0])
                                                {
                                                    if (childfile.Name == "question")
                                                    {
                                                        foreach (XmlNode childquestion in childfile.ChildNodes)
                                                        {
                                                            if (childquestion.Name == "quest")
                                                            {
                                                                Question.Text = childquestion.InnerText;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        case 7:
                            {
                                arra_1 = 1 + array[0] + array[1] + array[2] + array[3] + array[4] + array[5];
                                arra_2 = array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6];
                                flag_1 = 0;
                                for (int i = 0; i < 10; i++)
                                {
                                    rrand[i] = rnd.Next(arra_1, arra_2);
                                    //Console.WriteLine(rrand[i]);
                                }

                                do
                                {
                                    j = 1; k = 0;
                                    prov = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] == rrand[j])
                                            {
                                                rrand[i] = rnd.Next(arra_1, arra_2);
                                            }
                                            j++;
                                        }
                                        k++;
                                    }

                                    j = 1; k = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] != rrand[j])
                                            {
                                                prov++;
                                            }
                                            j++;
                                        }
                                        k++;
                                    }
                                    if (prov == 45) flag_1 = 1;
                                } while (flag_1 != 1);
                                /*for (int i = 0; i < 10; i++)
                                {
                                    Console.WriteLine(rrand[i]);
                                }*/
                            }

                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "addresses_and_pointers")
                                {
                                    foreach (XmlNode childaddresses_and_pointers in xnode.ChildNodes)
                                    {
                                        if (childaddresses_and_pointers.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childaddresses_and_pointers.Attributes.GetNamedItem("id");
                                            for (int i = 0; i < 1; i++)
                                            {
                                                int atrib;
                                                atrib = Convert.ToInt32(attr.Value);
                                                if (atrib == rrand[0])
                                                {
                                                    if (childaddresses_and_pointers.Name == "question")
                                                    {
                                                        foreach (XmlNode childquestion in childaddresses_and_pointers.ChildNodes)
                                                        {
                                                            if (childquestion.Name == "quest")
                                                            {
                                                                Question.Text = childquestion.InnerText;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        case 8:
                            {
                                arra_1 = 1 + array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6];
                                arra_2 = array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6] + array[7];
                                flag_1 = 0;
                                for (int i = 0; i < 10; i++)
                                {
                                    rrand[i] = rnd.Next(arra_1, arra_2);
                                    //Console.WriteLine(rrand[i]);
                                }

                                do
                                {
                                    j = 1; k = 0;
                                    prov = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] == rrand[j])
                                            {
                                                rrand[i] = rnd.Next(arra_1, arra_2);
                                            }
                                            j++;
                                        }
                                        k++;
                                    }

                                    j = 1; k = 0;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        j = 1 + k;
                                        while (j < 10)
                                        {
                                            if (rrand[i] != rrand[j])
                                            {
                                                prov++;
                                            }
                                            j++;
                                        }
                                        k++;
                                    }
                                    if (prov == 45) flag_1 = 1;
                                } while (flag_1 != 1);
                                /*for (int i = 0; i < 10; i++)
                                {
                                    Console.WriteLine(rrand[i]);
                                }*/
                            }

                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "dynamic_memory")
                                {
                                    foreach (XmlNode childdynamic_memory in xnode.ChildNodes)
                                    {
                                        if (childdynamic_memory.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childdynamic_memory.Attributes.GetNamedItem("id");
                                            for (int i = 0; i < 1; i++)
                                            {
                                                int atrib;
                                                atrib = Convert.ToInt32(attr.Value);
                                                if (atrib == rrand[0])
                                                {
                                                    if (childdynamic_memory.Name == "question")
                                                    {
                                                        foreach (XmlNode childquestion in childdynamic_memory.ChildNodes)
                                                        {
                                                            if (childquestion.Name == "quest")
                                                            {
                                                                Question.Text = childquestion.InnerText;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }
                flag_3 = 0;
            }
            
        }

        private void Question_Click(object sender, EventArgs e)
        {
           
        }

        private void AnswerIt_Click(object sender, EventArgs e)
        {
            if (Answer1.Checked)
                anser = 1;
            if (Answer2.Checked)
                anser = 2;
            if (Answer3.Checked)
                anser = 3;
            if (Answer4.Checked)
                anser = 4;
           
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            
            if(p<11)
            {
                switch (choice)
                {
                    case 1:
                        {
							foreach (XmlNode xnode in xRoot)
                            {
							if (xnode.Name == "cycles")
								{
                                    foreach (XmlNode childcycles in xnode.ChildNodes)
                                    {
                                        if (childcycles.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childcycles.Attributes.GetNamedItem("id");


                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p - 1])
                                            {
                                                if (childcycles.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childcycles.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "true")
                                                        {
                                                            tru = Convert.ToInt32(childquestion.InnerText);
                                                            if (anser == tru)
                                                            {
                                                                summ_tru += 1;
                                                            }
                                                            else
                                                            {
                                                                summ_false[p - 1] = p;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "arrays")
                                {
                                    foreach (XmlNode childarrays in xnode.ChildNodes)
                                    {
                                        if (childarrays.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childarrays.Attributes.GetNamedItem("id");


                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p - 1])
                                            {
                                                if (childarrays.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childarrays.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "true")
                                                        {
                                                            tru = Convert.ToInt32(childquestion.InnerText);
                                                            if (anser == tru)
                                                            {
                                                                summ_tru += 1;
                                                            }
                                                            else
                                                            {
                                                                summ_false[p - 1] = p;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "lines")
                                {
                                    foreach (XmlNode childlines in xnode.ChildNodes)
                                    {
                                        if (childlines.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childlines.Attributes.GetNamedItem("id");


                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p - 1])
                                            {
                                                if (childlines.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childlines.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "true")
                                                        {
                                                            tru = Convert.ToInt32(childquestion.InnerText);
                                                            if (anser == tru)
                                                            {
                                                                summ_tru += 1;
                                                            }
                                                            else
                                                            {
                                                                summ_false[p - 1] = p;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 4:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "recursion")
                                {
                                    foreach (XmlNode childrecursion in xnode.ChildNodes)
                                    {
                                        if (childrecursion.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childrecursion.Attributes.GetNamedItem("id");


                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p - 1])
                                            {
                                                if (childrecursion.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childrecursion.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "true")
                                                        {
                                                            tru = Convert.ToInt32(childquestion.InnerText);
                                                            if (anser == tru)
                                                            {
                                                                summ_tru += 1;
                                                            }
                                                            else
                                                            {
                                                                summ_false[p - 1] = p;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 5:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "struct")
                                {
                                    foreach (XmlNode childstruct in xnode.ChildNodes)
                                    {
                                        if (childstruct.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childstruct.Attributes.GetNamedItem("id");


                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p - 1])
                                            {
                                                if (childstruct.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childstruct.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "true")
                                                        {
                                                            tru = Convert.ToInt32(childquestion.InnerText);
                                                            if (anser == tru)
                                                            {
                                                                summ_tru += 1;
                                                            }
                                                            else
                                                            {
                                                                summ_false[p - 1] = p;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 6:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "file")
                                {
                                    foreach (XmlNode childfile in xnode.ChildNodes)
                                    {
                                        if (childfile.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childfile.Attributes.GetNamedItem("id");


                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p - 1])
                                            {
                                                if (childfile.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childfile.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "true")
                                                        {
                                                            tru = Convert.ToInt32(childquestion.InnerText);
                                                            if (anser == tru)
                                                            {
                                                                summ_tru += 1;
                                                            }
                                                            else
                                                            {
                                                                summ_false[p - 1] = p;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 7:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "addresses_and_pointers")
                                {
                                    foreach (XmlNode childaddresses_and_pointers in xnode.ChildNodes)
                                    {
                                        if (childaddresses_and_pointers.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childaddresses_and_pointers.Attributes.GetNamedItem("id");


                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p - 1])
                                            {
                                                if (childaddresses_and_pointers.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childaddresses_and_pointers.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "true")
                                                        {
                                                            tru = Convert.ToInt32(childquestion.InnerText);
                                                            if (anser == tru)
                                                            {
                                                                summ_tru += 1;
                                                            }
                                                            else
                                                            {
                                                                summ_false[p - 1] = p;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 8:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "dynamic_memory")
                                {
                                    foreach (XmlNode childdynamic_memory in xnode.ChildNodes)
                                    {
                                        if (childdynamic_memory.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childdynamic_memory.Attributes.GetNamedItem("id");


                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p - 1])
                                            {
                                                if (childdynamic_memory.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childdynamic_memory.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "true")
                                                        {
                                                            tru = Convert.ToInt32(childquestion.InnerText);
                                                            if (anser == tru)
                                                            {
                                                                summ_tru += 1;
                                                            }
                                                            else
                                                            {
                                                                summ_false[p - 1] = p;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
            }
           

            if (p < 10)
            {
                switch (choice)
                {
                    case 1:
                        {

                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "cycles")
                                {
                                    foreach (XmlNode childcycles in xnode.ChildNodes)
                                    {
                                        if (childcycles.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childcycles.Attributes.GetNamedItem("id");

                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p])
                                            {
                                                if (childcycles.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childcycles.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "quest")
                                                        {
                                                            Question.Text = childquestion.InnerText;
                                                        }
                                                    }
                                                }
                                            }



                                        }
                                    }
                                }
                            }

                        }
                        p += 1;
                        break;
                    case 2:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "arrays")
                                {
                                    foreach (XmlNode childarrays in xnode.ChildNodes)
                                    {
                                        if (childarrays.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childarrays.Attributes.GetNamedItem("id");

                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p])
                                            {
                                                if (childarrays.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childarrays.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "quest")
                                                        {
                                                            Question.Text = childquestion.InnerText;
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                        p += 1;
                        break;
                    case 3:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "lines")
                                {
                                    foreach (XmlNode childlines in xnode.ChildNodes)
                                    {
                                        if (childlines.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childlines.Attributes.GetNamedItem("id");
                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p])
                                            {
                                                if (childlines.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childlines.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "quest")
                                                        {
                                                            Question.Text = childquestion.InnerText;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        p += 1;
                        break;
                    case 4:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "recursion")
                                {
                                    foreach (XmlNode childrecursion in xnode.ChildNodes)
                                    {
                                        if (childrecursion.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childrecursion.Attributes.GetNamedItem("id");
                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p])
                                            {
                                                if (childrecursion.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childrecursion.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "quest")
                                                        {
                                                            Question.Text = childquestion.InnerText;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        p += 1;
                        break;
                    case 5:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "struct")
                                {
                                    foreach (XmlNode childstruct in xnode.ChildNodes)
                                    {
                                        if (childstruct.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childstruct.Attributes.GetNamedItem("id");
                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p])
                                            {
                                                if (childstruct.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childstruct.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "quest")
                                                        {
                                                            Question.Text = childquestion.InnerText;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        p += 1;
                        break;
                    case 6:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "file")
                                {
                                    foreach (XmlNode childfile in xnode.ChildNodes)
                                    {
                                        if (childfile.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childfile.Attributes.GetNamedItem("id");
                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p])
                                            {
                                                if (childfile.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childfile.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "quest")
                                                        {
                                                            Question.Text = childquestion.InnerText;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        p += 1;
                        break;
                    case 7:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "addresses_and_pointers")
                                {
                                    foreach (XmlNode childaddresses_and_pointers in xnode.ChildNodes)
                                    {
                                        if (childaddresses_and_pointers.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childaddresses_and_pointers.Attributes.GetNamedItem("id");
                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p])
                                            {
                                                if (childaddresses_and_pointers.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childaddresses_and_pointers.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "quest")
                                                        {
                                                            Question.Text = childquestion.InnerText;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        p += 1;
                        break;
                    case 8:
                        {
                            foreach (XmlNode xnode in xRoot)
                            {
                                if (xnode.Name == "dynamic_memory")
                                {
                                    foreach (XmlNode childdynamic_memory in xnode.ChildNodes)
                                    {
                                        if (childdynamic_memory.Attributes.Count > 0)
                                        {
                                            XmlNode attr = childdynamic_memory.Attributes.GetNamedItem("id");
                                            int atrib;
                                            atrib = Convert.ToInt32(attr.Value);
                                            if (atrib == rrand[p])
                                            {
                                                if (childdynamic_memory.Name == "question")
                                                {
                                                    foreach (XmlNode childquestion in childdynamic_memory.ChildNodes)
                                                    {
                                                        if (childquestion.Name == "quest")
                                                        {
                                                            Question.Text = childquestion.InnerText;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        p += 1;
                        break;
                }
            }
            else if (p == 10)
            {
                Rate_Click(sender, e);
                CountMistake_Click(sender, e);
                Numbers_Click(sender, e);
                p += 1;
                flag_3 = 1;
            }
        }

        private void CountMistake_Click(object sender, EventArgs e)
        {           
            CountMistake.Text = Convert.ToString(10-summ_tru);
        }

        private void Rate_Click(object sender, EventArgs e)
        {
            if((summ_tru==1)||(summ_tru==0)||(summ_tru==2))
            {
                Rate.Text = "1";
            }
            else if ((summ_tru == 3)||(summ_tru ==4))
            {
                Rate.Text = "2";
            }
            else if((summ_tru == 5)||(summ_tru ==6))
            {
                Rate.Text = "3";
            }
            else if((summ_tru ==7)||(summ_tru ==8))
            {
                Rate.Text = "4";
            }
            else if((summ_tru ==9)||(summ_tru ==10))
            {
                Rate.Text = "5";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Answer1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
