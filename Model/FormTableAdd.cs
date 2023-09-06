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
    public partial class FormTableAdd : SampleAdd
    {
        public FormTableAdd()
        {
            InitializeComponent();
        }

        private void FormTableAdd_Load(object sender, EventArgs e)
        {
            this.guna2PictureBox1.Image = RMS.Properties.Resources.chair;
        }

        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0) // insert
            {
                qry = "Insert into tables Values(@Name)";
            }
            else  // else
            {
                qry = "Update tables Set tName = @Name where tID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved successfully..");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }
    }
}
