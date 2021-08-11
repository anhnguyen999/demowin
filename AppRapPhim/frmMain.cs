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
            Button btn;
            int x;
            int y = 20, kc = 10;
            int count = 1;
            for (int i = 0; i < 3; i++)
            {
                x = 15;
                for (int j = 0; j < soLuongGhe / 3; j++)
                {
                    btn = new Button();
                    btn.Location = new System.Drawing.Point(x + 80 * j, y + 46 * i);
                    btn.Name = "btn" + count;
                    btn.Size = new System.Drawing.Size(80, 46);
                    btn.TabIndex = 0;
                    btn.Text = count.ToString();
                    btn.UseVisualStyleBackColor = true;
                    btn.BackColor = Color.White;
                    btn.Click += Btn_Click;
                    pnGhe.Controls.Add(btn);
                    count++;
                    x += kc;
                }
                y += kc;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đã được mua");
                return;
            }
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.Yellow;
            }
            else
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //tính tiền
        }
    }
}
