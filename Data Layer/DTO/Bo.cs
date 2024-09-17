using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Data_Layer.DTO
{
    class Bo : VatNuoi
    {
        private static Random rand = new Random();

        public override double VatSua()
        {
            return rand.NextDouble() * 20; // 0 toi 20 lit
        }

        public override string Keu()
        {
            return "Coww";
        }

        public override void SinhCon()
        {
            Quantity += rand.Next(1, 4);
        }
    }

}
