using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Data
{
    public class CauHinhData
    {
        private static CauHinhData _Ins;

        public static CauHinhData Ins
        {
            get
            {
                if (_Ins == null)
                {
                    _Ins = new CauHinhData();
                }
                return CauHinhData._Ins;
            }
            private set => CauHinhData._Ins = value;
        }

        private CauHinhData() { }

    }
}
