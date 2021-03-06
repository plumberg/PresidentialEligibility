﻿using Asgn_01_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Asgn_1
{
    public partial class Form1 : Form
    {
        int age;
        int resided;
        int terms;
        bool citizen = false;
        bool rebelled = false;
        
        public Form1()
        {
            InitializeComponent();
             
  
           // button1.Click += determine;

    }

        private void determine(object sender, EventArgs e)
        {
            Int32.TryParse(textBoxAge.Text, out age);
            Int32.TryParse(textBoxResided.Text, out resided);
            Int32.TryParse(textBoxTerms.Text, out terms);
            if (checkBox1.Checked)
            {
                citizen = true;
            }
            if (checkBox2.Checked)
            {
                rebelled = true;
            }

            Logic lib = new Logic(citizen, resided, age, terms, rebelled);

            if (lib.CheckElligibility() == true)
            {
                output.Text = "You are eligible";
            }
           else 
            { output.Text = "You are not qualified";}
            
            Refresh();

        }

    }
}
