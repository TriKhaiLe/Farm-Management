namespace GUI_Project
{
    partial class QLNongTrai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLuongSua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTiengKeu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVatSua = new System.Windows.Forms.Button();
            this.btnDe = new System.Windows.Forms.Button();
            this.btnKeu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbConnStr = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTen,
            this.colSoLuong,
            this.colLuongSua,
            this.colTiengKeu});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(377, 280);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trang Trại Z";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên thú nuôi";
            this.colTen.Width = 55;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            // 
            // colLuongSua
            // 
            this.colLuongSua.Text = "Lượng sữa";
            // 
            // colTiengKeu
            // 
            this.colTiengKeu.Text = "Tiếng kêu";
            this.colTiengKeu.Width = 142;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKeu);
            this.panel1.Controls.Add(this.btnDe);
            this.panel1.Controls.Add(this.btnVatSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 308);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(377, 48);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 280);
            this.panel2.TabIndex = 3;
            // 
            // btnVatSua
            // 
            this.btnVatSua.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVatSua.Location = new System.Drawing.Point(299, 3);
            this.btnVatSua.Name = "btnVatSua";
            this.btnVatSua.Size = new System.Drawing.Size(75, 42);
            this.btnVatSua.TabIndex = 0;
            this.btnVatSua.Text = "Vắt sữa";
            this.btnVatSua.UseVisualStyleBackColor = true;
            // 
            // btnDe
            // 
            this.btnDe.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDe.Location = new System.Drawing.Point(224, 3);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(75, 42);
            this.btnDe.TabIndex = 1;
            this.btnDe.Text = "Đẻ";
            this.btnDe.UseVisualStyleBackColor = true;
            // 
            // btnKeu
            // 
            this.btnKeu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKeu.Location = new System.Drawing.Point(149, 3);
            this.btnKeu.Margin = new System.Windows.Forms.Padding(5);
            this.btnKeu.Name = "btnKeu";
            this.btnKeu.Size = new System.Drawing.Size(75, 42);
            this.btnKeu.TabIndex = 2;
            this.btnKeu.Text = "Bỏ đói";
            this.btnKeu.UseVisualStyleBackColor = true;
            this.btnKeu.Click += new System.EventHandler(this.btnKeu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbConnStr);
            this.panel3.Controls.Add(this.btnConnect);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 264);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(377, 44);
            this.panel3.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConnect.Location = new System.Drawing.Point(299, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 38);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbConnStr
            // 
            this.tbConnStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConnStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConnStr.Location = new System.Drawing.Point(3, 3);
            this.tbConnStr.Multiline = true;
            this.tbConnStr.Name = "tbConnStr";
            this.tbConnStr.Size = new System.Drawing.Size(296, 38);
            this.tbConnStr.TabIndex = 1;
            this.tbConnStr.Text = "Data Source=DESKTOP-QC195PQ\\SQLEXPRESS;Initial Catalog=NongTraiDB;Integrated Secu" +
    "rity=True;Encrypt=False";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 234);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(377, 30);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Connection String";
            // 
            // QLNongTrai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 356);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "QLNongTrai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly Nong Trai";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colLuongSua;
        private System.Windows.Forms.ColumnHeader colTiengKeu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVatSua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKeu;
        private System.Windows.Forms.Button btnDe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbConnStr;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
    }
}