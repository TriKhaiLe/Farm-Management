using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Data_Layer.DTO
{
    public abstract class VatNuoi
    {
        public int Id { get; set; }
        public int SoLuong { get; set; }
        public double LuongSua { get; set; }
        public abstract string Keu();
        public abstract void VatSua();
        public abstract void SinhCon();
    }
}

