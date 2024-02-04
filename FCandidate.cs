using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Form_Project
{
    public partial class frmInfoCand : Form
    {
        public frmInfoCand()
        {
            InitializeComponent();
        }

        private void frmInfoCand_Load(object sender, EventArgs e)
        {
            txtName.Text = "NGUYỄN VĂN A";
            txtJob.Text = "Nhân viên kinh doanh";
        }
    }
}
