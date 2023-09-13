using Guna.UI2.WinForms;
using RMS.Reports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.Model
{
    public partial class FormBillList : Form
    {
        public FormBillList()
        {
            InitializeComponent();
        }

        public int MainID = 0;

        private void FormBillList_Load(object sender, EventArgs e)
        {
            //guna2PictureBox1.Image = RMS.Properties.Resources.receipt;
            LoadData();
        }

        private void LoadData() 
        {
            string qry = "select MainID, TableName, WaiterName, orderType, status, total from tblMain ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }


        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }


        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
               
                // this is change as we have to set form text properties before open
                
                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                this.Close();
            }

            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                //print Bill
                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = @"Select * from tblMain m inner join 
                                tblDetails d on d.MainID = m.MainID
                                inner join products p on p.pID = d.proID
                                where m.MainID = " + MainID + " ";

                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                MainClass.con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                MainClass.con.Close();
                FormPrint frm = new FormPrint();
                rptBill cr = new rptBill();

                cr.SetDatabaseLogon("RMS", "123");
                cr.SetDataSource(dt);

                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.Refresh();
                frm.Show();
                
                
            }

        }


    }


}
