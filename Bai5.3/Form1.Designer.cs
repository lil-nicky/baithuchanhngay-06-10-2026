namespace Bai53
{
    partial class Form53
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpProduct;
        private GroupBox grpFunction;

        private Label lblProductId;
        private Label lblProductName;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblCategory;
        private Label lblSearch;

        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtSearch;

        private ComboBox cboCategory;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;

        private DataGridView dgvProducts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            grpProduct = new GroupBox();
            grpFunction = new GroupBox();

            lblProductId = new Label();
            lblProductName = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            lblCategory = new Label();
            lblSearch = new Label();

            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            txtSearch = new TextBox();

            cboCategory = new ComboBox();

            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();

            dgvProducts = new DataGridView();

            grpProduct.SuspendLayout();
            grpFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts)
                .BeginInit();

            SuspendLayout();

            // =========================
            // FORM
            // =========================
            Text = "Quản lý danh sách sản phẩm";

            StartPosition =
                FormStartPosition.CenterScreen;

            ClientSize =
                new Size(1000, 650);

            MinimumSize =
                new Size(850, 550);

            // =========================
            // GROUP SẢN PHẨM
            // =========================
            grpProduct.Text =
                "Thông tin sản phẩm";

            grpProduct.Location =
                new Point(20, 20);

            grpProduct.Size =
                new Size(960, 160);

            // Mã sản phẩm
            lblProductId.Text =
                "Mã sản phẩm:";

            lblProductId.Location =
new Point(20, 35);

            lblProductId.AutoSize = true;

            txtProductId.Location =
                new Point(130, 32);

            txtProductId.Size =
                new Size(220, 27);

            // Tên sản phẩm
            lblProductName.Text =
                "Tên sản phẩm:";

            lblProductName.Location =
                new Point(400, 35);

            lblProductName.AutoSize = true;

            txtProductName.Location =
                new Point(520, 32);

            txtProductName.Size =
                new Size(300, 27);

            // Đơn giá
            lblUnitPrice.Text =
                "Đơn giá:";

            lblUnitPrice.Location =
                new Point(20, 80);

            lblUnitPrice.AutoSize = true;

            txtUnitPrice.Location =
                new Point(130, 77);

            txtUnitPrice.Size =
                new Size(220, 27);

            // Số lượng
            lblQuantity.Text =
                "Số lượng:";

            lblQuantity.Location =
                new Point(400, 80);

            lblQuantity.AutoSize = true;

            txtQuantity.Location =
                new Point(520, 77);

            txtQuantity.Size =
                new Size(120, 27);

            // Danh mục
            lblCategory.Text =
                "Danh mục:";

            lblCategory.Location =
                new Point(20, 120);

            lblCategory.AutoSize = true;

            cboCategory.Location =
                new Point(130, 117);

            cboCategory.Size =
                new Size(220, 28);

            cboCategory.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboCategory.Items.AddRange(
                new object[]
                {
                    "Điện thoại",
                    "Laptop",
                    "Phụ kiện"
                });

            grpProduct.Controls.Add(lblProductId);
            grpProduct.Controls.Add(txtProductId);

            grpProduct.Controls.Add(lblProductName);
            grpProduct.Controls.Add(txtProductName);

            grpProduct.Controls.Add(lblUnitPrice);
            grpProduct.Controls.Add(txtUnitPrice);

            grpProduct.Controls.Add(lblQuantity);
            grpProduct.Controls.Add(txtQuantity);

            grpProduct.Controls.Add(lblCategory);
            grpProduct.Controls.Add(cboCategory);

            // =========================
            // GROUP CHỨC NĂNG
            // =========================
            grpFunction.Text =
                "Chức năng";

            grpFunction.Location =
                new Point(20, 195);

            grpFunction.Size =
                new Size(960, 70);

            // Nút thêm
            btnAdd.Text =
                "Thêm";

            btnAdd.Location =
                new Point(20, 25);

            btnAdd.Size =
                new Size(90, 32);

            btnAdd.Click +=
btnAdd_Click;

            // Nút sửa
            btnUpdate.Text =
                "Sửa";

            btnUpdate.Location =
                new Point(120, 25);

            btnUpdate.Size =
                new Size(90, 32);

            btnUpdate.Click +=
                btnUpdate_Click;

            // Nút xóa
            btnDelete.Text =
                "Xóa";

            btnDelete.Location =
                new Point(220, 25);

            btnDelete.Size =
                new Size(90, 32);

            btnDelete.Click +=
                btnDelete_Click;

            // Label tìm kiếm
            lblSearch.Text =
                "Tìm kiếm:";

            lblSearch.Location =
                new Point(500, 32);

            lblSearch.AutoSize = true;

            // Ô tìm kiếm
            txtSearch.Location =
                new Point(570, 28);

            txtSearch.Size =
                new Size(220, 27);

            // Nút tìm kiếm
            btnSearch.Text =
                "Tìm kiếm";

            btnSearch.Location =
                new Point(800, 27);

            btnSearch.Size =
                new Size(100, 32);

            btnSearch.Click +=
                btnSearch_Click;

            grpFunction.Controls.Add(btnAdd);
            grpFunction.Controls.Add(btnUpdate);
            grpFunction.Controls.Add(btnDelete);
            grpFunction.Controls.Add(lblSearch);
            grpFunction.Controls.Add(txtSearch);
            grpFunction.Controls.Add(btnSearch);

            // =========================
            // DATAGRIDVIEW
            // =========================
            dgvProducts.Location =
                new Point(20, 285);

            dgvProducts.Size =
                new Size(960, 330);

            dgvProducts.AllowUserToAddRows =
                false;

            dgvProducts.AllowUserToDeleteRows =
                false;

            dgvProducts.ReadOnly =
                true;

            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.MultiSelect =
                false;

            dgvProducts.AutoGenerateColumns =
                false;

            dgvProducts.CellClick +=
                dgvProducts_CellClick;

            // Cột Mã SP
            dgvProducts.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "ProductId",
                    HeaderText = "Mã SP",
                    DataPropertyName = "ProductId",
                    Width = 130
                });

            // Cột Tên SP
            dgvProducts.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "ProductName",
                    HeaderText = "Tên sản phẩm",
                    DataPropertyName = "ProductName",
                    Width = 260
                });

            // Cột Đơn giá
            dgvProducts.Columns.Add(
                            new DataGridViewTextBoxColumn
                            {
                                Name = "UnitPrice",
                                HeaderText = "Đơn giá",
                                DataPropertyName = "UnitPrice",
                                Width = 150
                            });

            // Cột Số lượng
            dgvProducts.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "Quantity",
                    HeaderText = "Số lượng",
                    DataPropertyName = "Quantity",
                    Width = 120
                });

            // Cột Danh mục
            dgvProducts.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "Category",
                    HeaderText = "Danh mục",
                    DataPropertyName = "Category",
                    Width = 180
                });

            // =========================
            // ADD CONTROLS
            // =========================
            Controls.Add(grpProduct);
            Controls.Add(grpFunction);
            Controls.Add(dgvProducts);
            grpProduct.ResumeLayout(false);

            grpProduct.PerformLayout();

            grpFunction.ResumeLayout(false);

            grpFunction.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)dgvProducts)

                .EndInit();

            ResumeLayout(false);

        }

    }
}
