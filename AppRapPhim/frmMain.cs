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
        int soLuongGhe = 15;

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            KhoiTaoGhe();
        }

        private void KhoiTaoGhe()
        {
            //
            Button btn = new Button();
            btn.Location = new System.Drawing.Point(15, 20);
            btn.Name = "btn1";
            btn.Size = new System.Drawing.Size(80, 46);
            btn.TabIndex = 0;
            btn.Text = "1";
            btn.UseVisualStyleBackColor = true;
            pnGhe.Controls.Add(btn);
        }
    }
}
