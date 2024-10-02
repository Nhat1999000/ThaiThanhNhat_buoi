using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiThanhNhat_buoi
{
    internal class SINHVIENBIZ
    {
    }
    internal class SinhVienBiz : SinhVien
    {
        public double ketoan;
        public double marketting;
        public double banhang;
        public override double getDiemTB()
        {
            return (ketoan + marketting + banhang) / 3;
        }
    }
}
