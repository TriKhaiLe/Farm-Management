using GUI_Project.Data_Layer;
using GUI_Project.Data_Layer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Project.Business_Layer
{
    public class VatNuoiBLL
    {
        private VatNuoiDAL dal;
        public List<VatNuoi> dsVatNuoi = new List<VatNuoi>();
        ConnectionManager connectionManager = new ConnectionManager();
        public bool isDatabaseConnect = false;
        public int tongSL = 0;
        public double tongLitSua = 0;

        public VatNuoiBLL(string newConnStr)
        {
            if (!connectionManager.IsConnectionStringValid(newConnStr))
            {
                MessageBox.Show("Ket noi That Bai");
                return;
            }
            isDatabaseConnect = true;
            connectionManager.SaveConnectionString(newConnStr);
            dal = new VatNuoiDAL(newConnStr);
        }

        public void LayDSVatNuoi()
        {
            dsVatNuoi.Clear();
            tongSL = 0;
            tongLitSua = 0;
            DataTable dt = dal.LayDSVatNuoi();
            foreach (DataRow row in dt.Rows)
            {
                // Convert DataRow to Livestock object
                VatNuoi vatNuoi = null;
                switch (row["LoaiVat"].ToString())
                {
                    case "Bo":
                        vatNuoi = new Bo();
                        break;
                    case "Cuu":
                        vatNuoi = new Cuu();
                        break;
                    case "De":
                        vatNuoi = new De();
                        break;
                }
                if (vatNuoi != null)
                {
                    vatNuoi.SoLuong = (int)row["SoLuong"];
                    vatNuoi.LuongSua = (double)row.Field<decimal>("LuongSua");
                    dsVatNuoi.Add(vatNuoi);
                    tongSL += vatNuoi.SoLuong;
                    tongLitSua += vatNuoi.LuongSua;
                }
            }
        }

        public void LuuDSVatNuoi()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("LoaiVat", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("LuongSua", typeof(decimal));

            foreach (var vatNuoi in dsVatNuoi)
            {
                DataRow row = dt.NewRow();
                row["LoaiVat"] = vatNuoi.GetType().Name;
                row["SoLuong"] = vatNuoi.SoLuong;
                row["LuongSua"] = vatNuoi.LuongSua;
                dt.Rows.Add(row);
            }

            dal.CapNhatDSVatNuoi(dt);
        }

        public string BoDoi()
        {
            return string.Join("\n", dsVatNuoi.Select(vn => vn.Keu()));
        }

        //public (int cowCount, int sheepCount, int goatCount, double totalMilk) GetStatistics()
        //{
        //    int cowCount = dsVatNuoi.OfType<Bo>().Sum(c => c.SoLuong);
        //    //int sheepCount = dsVatNuoi.OfType<Cuu>().Sum(s => s.Quantity);
        //    //int goatCount = dsVatNuoi.OfType<De>().Sum(g => g.Quantity);
        //    double totalMilk = dsVatNuoi.Sum(l => l.VatSua());

        //    return (cowCount, sheepCount, goatCount, totalMilk);
        //}

        public void SinhSan()
        {
            foreach (var vn in dsVatNuoi)
            {
                vn.SinhCon();
            }

            LuuDSVatNuoi();
        }

        public void KhoiTaoCSDL()
        {
            try
            {
                string connStr = connectionManager.GetCurrentConnectionString();
                string dbName = connectionManager.GetDatabaseName(connStr);
                var dbInitializer = new DatabaseInitializer(connStr, dbName);
                dbInitializer.InitializeDatabase(); // khoi tao table neu chua ton tai

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
