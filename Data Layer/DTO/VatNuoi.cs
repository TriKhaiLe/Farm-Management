using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Data_Layer.DTO
{
    abstract class VatNuoi
    {
        public abstract string Ten { get; }
        public abstract string TiengKeu { get; }

        public abstract void Keu();
        public abstract float VatSua();
        public abstract VatNuoi SinhCon();
    }
}

