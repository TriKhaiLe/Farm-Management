using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Data_Layer.DTO
{
    abstract class VatNuoi
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public abstract string Keu();
        public abstract double VatSua();
        public abstract void SinhCon();
    }
}

