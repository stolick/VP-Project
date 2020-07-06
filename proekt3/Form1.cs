using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proekt3
{
    public partial class Form1 : Form
    {
        Scores score = new Scores();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.DialogResult = DialogResult.OK;
            form2.ShowDialog();
   //         this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();                  
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            score.changeHighest(Form2.highest);
            score.ShowDialog();            
        }
    
}}