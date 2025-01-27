﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsDnevnik
{
    public partial class Main : Form
    {
        bool status = false;
        public Main()
        {
            InitializeComponent();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!status) {
                Osoba nova = new Osoba();
                nova.Show();
                status = true;
            }
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!status)
            {
                Raspodela nova = new Raspodela();
                nova.Show();
                status = true;
            }
        }
    }
}
