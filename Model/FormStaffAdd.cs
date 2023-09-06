using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.Model
{
    public partial class FormStaffAdd : SampleAdd
    {
        public FormStaffAdd()
        {
            InitializeComponent();
        }

        private void FormStaffAdd_Load(object sender, EventArgs e)
        {
            this.guna2PictureBox1.Image = RMS.Properties.Resources.reputation;
        }

        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0) // insert
            {
                qry = "Insert into Staff Values(@Name, @phone, @role)";
            }
            else  // else
            {
                qry = "Update Staff Set sName = @Name, sPhone = @phone, sRole = @role where staffID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@phone", txtPhone.Text);
            ht.Add("@role", cbRole.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved successfully..");
                id = 0;
                txtName.Text = "";
                txtPhone.Text = "";
                cbRole.SelectedIndex = -1;
                txtName.Focus();
            }
        }
    }
}
