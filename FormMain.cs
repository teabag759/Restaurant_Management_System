using RMS.Model;
using RMS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // for accessing FormMain

        static FormMain _obj;

        public static FormMain Instance
        { 
            get {  if ( _obj == null ) { _obj = new FormMain(); } return _obj; }
        }

        //Methord to add Controls in Main Form
        public void AddControls(Form f)
        {
            ControlsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlsPanel.Controls.Add(f);
            f.Show();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = MainClass.USER;
            _obj = this;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new FormHome());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            AddControls(new View.FormCategoryView());
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            AddControls(new View.FormTableView());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControls(new View.FormStaffView());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            AddControls(new View.FormProductView());
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            FormPOS frm = new FormPOS();
            frm.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            AddControls(new View.FormKitchenView());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AddControls(new View.FormReports());
        }
    }
}
