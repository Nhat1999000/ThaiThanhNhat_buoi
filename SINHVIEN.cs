﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace ThaiThanhNhat_buoi
{
    internal class SINHVIEN
    {
    }
    abstract internal class SinhVien
    {
        public string hoten;
        abstract public double getDiemTB();
        public virtual string xeploai()
        {
            if (getDiemTB() > 5 && getDiemTB() < 7)
            {
                return " trung bình";
            }
            else if (getDiemTB() > 7)
            {
                return " giỏi";
            }
            else
            {
                return " yếu";
            }
            return " kém";
            { }
        }
    }
}
