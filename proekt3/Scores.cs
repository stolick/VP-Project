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
    public partial class Scores : Form
    {
        public int Score { get; set; }
        public Scores()
        {
            InitializeComponent();
        }
        public void changeHighest(int highest)
        {
            this.highestScore.Text = highest.ToString();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
