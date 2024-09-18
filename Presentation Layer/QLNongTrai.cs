using GUI_Project.Business_Layer;
using GUI_Project.Data_Layer.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Project
{
    public partial class QLNongTrai : Form
    {
        public VatNuoiBLL bll;
        public QLNongTrai()
        {
            InitializeComponent();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void InitializeApplication()
        {
        }

        private void HienThiDuLieu()
        {
            bll.LayDSVatNuoi();
            listView1.Items.Clear();

            foreach (var vatNuoi in bll.dsVatNuoi) 
            {
                // Create a new ListViewItem for each livestock
                var item = new ListViewItem(vatNuoi.GetType().Name);
                item.SubItems.Add(vatNuoi.SoLuong.ToString()); // Add quantity as a subitem
                item.SubItems.Add(vatNuoi.LuongSua.ToString()); // Add type as a subitem

                // Add the ListViewItem to the ListView
                listView1.Items.Add(item);
            }

            var lastItem = new ListViewItem("Tổng");
            lastItem.SubItems.Add(bll.tongSL.ToString()); 
            lastItem.SubItems.Add(bll.tongLitSua.ToString()); 
            listView1.Items.Add(lastItem);
        }

        private void btnKeu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bll.BoDoi());
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string newConnStr = tbConnStr.Text.Trim();
            bll = new VatNuoiBLL(newConnStr); // include check valid connection string
            if (bll.isDatabaseConnect)
            {
                bll.KhoiTaoCSDL();  // BLL handles database initialization
                HienThiDuLieu();  // Load livestock data into the UI
                btnKeu.Enabled = true;
                btnDe.Enabled = true;
                btnVatSua.Enabled = true;
            }
        }
    }     
}
