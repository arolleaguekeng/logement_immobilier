﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogementImobilier.Winform
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panelEmail.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            panelEmail.Visible = false;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            panelEmail.Visible = true;
        }
    }
}