namespace Bai54
{
    partial class Form54
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvDepartments;
        private System.Windows.Forms.ListView lsvEmployees;
        private System.Windows.Forms.ComboBox cboViewMode;
        private System.Windows.Forms.Label lblViewMode;

        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colChucVu;
        private System.Windows.Forms.ColumnHeader colNgayVao;

        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            tvDepartments = new TreeView();
            lsvEmployees = new ListView();
            colMaNV = new ColumnHeader();
            colHoTen = new ColumnHeader();
            colChucVu = new ColumnHeader();
            colNgayVao = new ColumnHeader();
            imageListLarge = new ImageList(components);
            imageListSmall = new ImageList(components);
            cboViewMode = new ComboBox();
            lblViewMode = new Label();
            imageListTree = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvDepartments);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lsvEmployees);
            splitContainer1.Panel2.Controls.Add(cboViewMode);
            splitContainer1.Panel2.Controls.Add(lblViewMode);
            splitContainer1.Size = new Size(1000, 650);
            splitContainer1.SplitterDistance = 198;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // tvDepartments
            // 
            tvDepartments.Dock = DockStyle.Fill;
            tvDepartments.Font = new Font("Segoe UI", 10F);
            tvDepartments.HideSelection = false;
            tvDepartments.Location = new Point(0, 0);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.Size = new Size(198, 650);
            tvDepartments.TabIndex = 0;
            tvDepartments.AfterSelect += tvDepartments_AfterSelect;
            // 
            // lsvEmployees
            // 
            lsvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsvEmployees.Columns.AddRange(new ColumnHeader[] { colMaNV, colHoTen, colChucVu, colNgayVao });
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.LargeImageList = imageListLarge;
            lsvEmployees.Location = new Point(20, 49);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(775, 589);
            lsvEmployees.SmallImageList = imageListSmall;
            lsvEmployees.TabIndex = 2;
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = View.Details;
            // 
            // colMaNV
            // 
            colMaNV.Text = "Mã NV";
            colMaNV.Width = 100;
            // 
            // colHoTen
            // 
            colHoTen.Text = "Họ Tên";
            colHoTen.Width = 190;
            // 
            // colChucVu
            // 
            colChucVu.Text = "Chức vụ";
            colChucVu.Width = 170;
            // 
            // colNgayVao
            // 
            colNgayVao.Text = "Ngày vào";
            colNgayVao.Width = 120;
            // 
            // imageListLarge
            // 
            imageListLarge.ColorDepth = ColorDepth.Depth32Bit;
            imageListLarge.ImageSize = new Size(64, 64);
            imageListLarge.TransparentColor = Color.Transparent;
            // 
            // imageListSmall
            // 
            imageListSmall.ColorDepth = ColorDepth.Depth32Bit;
            imageListSmall.ImageSize = new Size(32, 32);
            imageListSmall.TransparentColor = Color.Transparent;
            // 
            // cboViewMode
            // 
            cboViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboViewMode.Font = new Font("Segoe UI", 10F);
            cboViewMode.FormattingEnabled = true;
            cboViewMode.Items.AddRange(new object[] { "Details", "SmallIcon", "LargeIcon", "Tile" });
            cboViewMode.Location = new Point(148, 12);
            cboViewMode.Name = "cboViewMode";
            cboViewMode.Size = new Size(160, 31);
            cboViewMode.TabIndex = 1;
            cboViewMode.SelectedIndexChanged += cboViewMode_SelectedIndexChanged;
            // 
            // lblViewMode
            // 
            lblViewMode.AutoSize = true;
            lblViewMode.Font = new Font("Segoe UI", 10F);
            lblViewMode.Location = new Point(20, 15);
            lblViewMode.Name = "lblViewMode";
            lblViewMode.Size = new Size(132, 23);
            lblViewMode.TabIndex = 3;
            lblViewMode.Text = "Chế độ hiển thị:";
            // 
            // imageListTree
            // 
            imageListTree.ColorDepth = ColorDepth.Depth32Bit;
            imageListTree.ImageSize = new Size(16, 16);
            imageListTree.TransparentColor = Color.Transparent;
            // 
            // Form54
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(800, 500);
            Name = "Form54";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trình quản lý tập tin";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}