using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Data_Layer.DTO
{
    class Bo : VatNuoi
    {
        public override void VatSua()
        {
            for (int i = 0; i < SoLuong; i++)
            {
                LuongSua += rand.NextDouble() * 20;
            }
        }

        public override string Keu()
        {
            string sound = "";
            for (int i = 0; i < SoLuong; i++)
            {
                sound += "Coww ";
            }
            return sound;
        }

        public override void SinhCon()
        {
            int slBanDau = SoLuong;
            for (int i = 0; i < slBanDau; i++)
            {
                SoLuong += rand.Next(1, 4);
            }
        }
    }

}
