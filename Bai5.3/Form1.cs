using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai53
{
    public partial class Form53 : Form
    {
        private readonly List<Product> products =
            new List<Product>();

        private readonly BindingSource bindingSource =
            new BindingSource();

        private Product selectedProduct = null;

        public Form53()
        {
            InitializeComponent();

            // Kết nối List<Product> với BindingSource
            bindingSource.DataSource = products;
            dgvProducts.DataSource = bindingSource;
        }

        // =========================
        // THÊM SẢN PHẨM
        // =========================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            string id = txtProductId.Text.Trim();

            // Kiểm tra mã sản phẩm trùng
            foreach (Product p in products)
            {
                if (p.ProductId.Equals(
                    id,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Mã sản phẩm đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            Product product = new Product
            {
                ProductId = id,
                ProductName = txtProductName.Text.Trim(),
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                Category = cboCategory.Text
            };

            products.Add(product);

            RefreshData();

            ClearInput();

            MessageBox.Show(
                "Thêm sản phẩm thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================
        // SỬA SẢN PHẨM
        // =========================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show(
                    "Hãy chọn sản phẩm cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidateInput())
                return;

            string newId = txtProductId.Text.Trim();

            // Kiểm tra trùng mã với sản phẩm khác
            foreach (Product p in products)
            {
                if (p != selectedProduct &&
                    p.ProductId.Equals(
                        newId,
                        StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                                            "Mã sản phẩm đã tồn tại!",
                                            "Thông báo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);

                    return;
                }
            }

            selectedProduct.ProductId = newId;
            selectedProduct.ProductName =
                txtProductName.Text.Trim();

            selectedProduct.UnitPrice =
                decimal.Parse(txtUnitPrice.Text);

            selectedProduct.Quantity =
                int.Parse(txtQuantity.Text);

            selectedProduct.Category =
                cboCategory.Text;

            RefreshData();

            ClearInput();

            MessageBox.Show(
                "Cập nhật sản phẩm thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================
        // XÓA SẢN PHẨM
        // =========================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show(
                    "Hãy chọn sản phẩm cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sản phẩm này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                products.Remove(selectedProduct);

                selectedProduct = null;

                RefreshData();

                ClearInput();
            }
        }

        // =========================
        // NÚT TÌM KIẾM
        // =========================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword =
                txtSearch.Text.Trim();

            // Nếu ô tìm kiếm trống
            // thì hiển thị toàn bộ sản phẩm
            if (string.IsNullOrWhiteSpace(keyword))
            {
                bindingSource.DataSource = products;
                bindingSource.ResetBindings(false);

                return;
            }

            // Danh sách kết quả
            List<Product> result =
                products.FindAll(p =>
                    p.ProductId.IndexOf(
                        keyword,
                        StringComparison.OrdinalIgnoreCase) >= 0

                    ||

                    p.ProductName.IndexOf(
                        keyword,
                        StringComparison.OrdinalIgnoreCase) >= 0
                );

            bindingSource.DataSource = result;
            bindingSource.ResetBindings(false);
            if (result.Count == 0)
            {
                MessageBox.Show(
                    "Không tìm thấy sản phẩm!",
                    "Kết quả tìm kiếm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // =========================
        // CLICK VÀO DÒNG
        // =========================
        private void dgvProducts_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvProducts.Rows[e.RowIndex];

            if (row.Cells["ProductId"].Value == null)
                return;

            string id =
                row.Cells["ProductId"].Value.ToString();

            selectedProduct = products.Find(
                p => p.ProductId == id);

            if (selectedProduct == null)
                return;

            txtProductId.Text =
                selectedProduct.ProductId;

            txtProductName.Text =
                selectedProduct.ProductName;

            txtUnitPrice.Text =
                selectedProduct.UnitPrice.ToString();

            txtQuantity.Text =
                selectedProduct.Quantity.ToString();

            cboCategory.Text =
                selectedProduct.Category;
        }

        // =========================
        // KIỂM TRA DỮ LIỆU
        // =========================
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(
                txtProductId.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sản phẩm!");

                txtProductId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtProductName.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên sản phẩm!");

                txtProductName.Focus();
                return false;
            }

            if (!decimal.TryParse(
                txtUnitPrice.Text,
                out decimal price) ||
                price <= 0)
            {
                MessageBox.Show(
                    "Đơn giá phải lớn hơn 0!");

                txtUnitPrice.Focus();
                return false;
            }

            if (!int.TryParse(
                txtQuantity.Text,
                out int quantity) ||
                quantity < 0)
            {
                MessageBox.Show(
                    "Số lượng không hợp lệ!");

                txtQuantity.Focus();
                return false;
            }

            if (cboCategory.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn danh mục!");

                cboCategory.Focus();
                return false;
            }

            return true;
        }
        // =========================
        // CẬP NHẬT DATAGRIDVIEW
        // =========================
        private void RefreshData()
        {
            bindingSource.DataSource = null;
            bindingSource.DataSource = products;
            dgvProducts.DataSource = bindingSource;

            bindingSource.ResetBindings(false);
        }

        // =========================
        // XÓA Ô NHẬP
        // =========================
        private void ClearInput()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();

            cboCategory.SelectedIndex = -1;

            selectedProduct = null;

            txtProductId.Focus();
        }
    }

    // =========================
    // CLASS PRODUCT
    // =========================
    public class Product
    {
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public string Category { get; set; }
    }
}