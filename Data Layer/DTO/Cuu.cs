using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Data_Layer.DTO
{
    internal class Cuu : VatNuoi
    {
        private static Random rand = new Random();

        public override void VatSua()
        {
            for (int i = 0; i < SoLuong; i++)
            {
                LuongSua += rand.NextDouble() * 5;
            }
        }

        public override string Keu()
        {
            string sound = "";
            for (int i = 0; i < SoLuong; i++)
            {
                sound += "Sheepp ";
            }
            return sound;
        }

        public override void SinhCon()
        {
            for (int i = 0; i < SoLuong; i++)
            {
                SoLuong += rand.Next(1, 4);
            }
        }

    }
}
