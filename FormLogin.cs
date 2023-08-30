﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RMS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (MainClass.IsVaildUser(txtUser.Text, txtPass.Text) == false)
            {
                guna2MessageDialog1.Show("invalid username or password");
                return;
            }

            else { 
                this.Hide();
                FormMain frm = new FormMain();
                frm.Show();
            }
        }
    }
}
