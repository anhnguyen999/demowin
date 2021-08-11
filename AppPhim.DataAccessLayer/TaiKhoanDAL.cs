using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPhim.DataAccessLayer
{
    public class TaiKhoanDAL
    {
        public bool KiemTraDangNhap(TaiKhoan taiKhoan, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new AppPhimModel())
                {
                    return dbcontext.TaiKhoan.Any(tk=>tk.UserName == taiKhoan.UserName && tk.PassWord == taiKhoan.PassWord);
                }
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }
    }
}
