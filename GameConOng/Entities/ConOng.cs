using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConOng.Entities
{
    abstract class ConOng
    {
        public int soMau = 100;

        protected int soMauToiThieu;

        public ConOng(int soMauToiThieu)
        {
            this.soMauToiThieu = soMauToiThieu;
        }

        public string GetTrangThai()
        {
            return soMau >= soMauToiThieu ? "SONG" : "CHET";
        }

        public void TanCong(int soMauTanCong)
        {
            if (GetTrangThai() == "SONG")
            {
                soMau -= soMauTanCong;
            }
        }
    }
}
