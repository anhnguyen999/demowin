using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRapPhim
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void OpenBanVe_Click(object sender, EventArgs e)
        {
            //kiểm tra sự tồn tại của frmBanVe trước khi tạo form mới
            Form frm = this.MdiChildren.OfType<frmBanVe>().FirstOrDefault();
            if (frm == null)
            {
                frmBanVe frmBanVe = new frmBanVe();
                frmBanVe.MdiParent = this;
                frmBanVe.Show();
            }
            else
            {
                frm.Activate();
            }
        }
    }
}
