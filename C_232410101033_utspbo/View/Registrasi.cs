﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_232410101033_utspbo.View
{
    public partial class Registrasi : Form
    {
        public Registrasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Close();
            welcome.Show();
        }
    }
}
