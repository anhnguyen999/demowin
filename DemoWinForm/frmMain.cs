using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinForm
{
    public partial class frmMain : Form
    {
        //prefix_
        //frm Form
        //mnu Form menu
        //cmd  Command button
        //chk Check button
        //opt  Radio button
        //lbl Text label
        //txt  Text edit box
        //pb   Picture box
        //pic Picture
        //lst List box
        //cbo  Combo box
        //tmr Timer
        //btn Button

        string erorMgs;
        public frmMain()
        {
            InitializeComponent();
        }

        private void PhepTinh_Click(object sender, EventArgs e)
        {
            if (ValidateNumber(txtSoA) && ValidateNumber(txtSoB))
            {
                //ép kiểu từ sender sang button
                Button button = (Button)sender;
                float soA = float.Parse(txtSoA.Text);
                float soB = float.Parse(txtSoB.Text);
                float ketQua = 0;
                switch (button.Name)
                {
                    case "btnCong":
                        ketQua = soA + soB;
                        break;
                    case "btnTru":
                        ketQua = soA - soB;
                        break;
                    case "btnNhan":
                        ketQua = soA * soB;
                        break;
                    case "btnChia":
                        if(soB == 0)
                        {
                            MessageBox.Show("Số B phải khác số 0!");
                            return;
                        }
                        ketQua = soA / soB;
                        break;

                    default:
                        break;
                }
                txtKetQua.Text = ketQua.ToString();
            }
            else
            {
                MessageBox.Show("Số nhập vào không hợp lệ!");
                return;
            }
            
        }

        private void TxtSo_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumber(sender);
            lblError.Text = erorMgs;
        }

        private bool ValidateNumber(object sender)
        {
            TextBox txtSo = (TextBox)sender;
            if (txtSo.Text == "")
            {
                errorProvider1.SetError(txtSo, "Số không được rỗng!");
                erorMgs += txtSo.Name + " không được để rỗng!\n";
                return false;
            }
            try
            {
                float.Parse(txtSo.Text);
            }
            catch (Exception)
            {
                errorProvider1.SetError(txtSo, "Số đã nhập không hợp lệ!");
                erorMgs += txtSo.Name + " nhập không hợp lệ!\n";
                return false;
            }
            errorProvider1.SetError(txtSo, "");
            erorMgs = "";
            return true;
        }
    }
}
