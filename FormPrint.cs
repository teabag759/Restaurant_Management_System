﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class FormPrint : Form
    {
        public FormPrint()
        {
            InitializeComponent();
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {
            btnMax.PerformClick();
        }
    }
}
