using System;
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
    public partial class SampleAdd : Form
    {
        public SampleAdd()
        {
            InitializeComponent();
        }

        public virtual void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void FormCategoryAdd_Load(object sender, EventArgs e)
        {
            this.guna2PictureBox1.Image = RMS.Properties.Resources.categories;
        }
    }
}
