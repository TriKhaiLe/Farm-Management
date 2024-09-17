using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Data_Layer.DTO
{
    class Bo : VatNuoi
    {
        float luongSua = 0;
        int soCon = 0;

        public override string Ten {
            get { return "Cow"; }
        }

        public override string TiengKeu => throw new NotImplementedException();

        public override float VatSua()
        {
            throw new NotImplementedException();
        }

        public override void Keu()
        {
            throw new NotImplementedException();
        }

        public override VatNuoi SinhCon()
        {
            throw new NotImplementedException();
        }
    }

}
