namespace Bai52
{
    partial class Form52
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cboCategory;
        private ListBox lstAvailableServices;
        private ListBox lstSelectedServices;

        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;

        private TextBox txtDiscount;

        private Label lblTotalValue;
        private Label lblDiscountValue;
        private Label lblFinalValue;

        private Label lblCategory;
        private Label lblAvailable;
        private Label lblSelected;
        private Label lblTotal;
        private Label lblDiscount;
        private Label lblFinal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            cboCategory = new ComboBox();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();

            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();

            txtDiscount = new TextBox();

            lblTotalValue = new Label();
            lblDiscountValue = new Label();
            lblFinalValue = new Label();

            lblCategory = new Label();
            lblAvailable = new Label();
            lblSelected = new Label();
            lblTotal = new Label();
            lblDiscount = new Label();
            lblFinal = new Label();

            SuspendLayout();

            Text = "Bảng tính tiền dịch vụ";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(850, 550);
            MinimumSize = new Size(750, 500);

            lblCategory.Text = "Loại dịch vụ:";
            lblCategory.Location = new Point(30, 25);
            lblCategory.AutoSize = true;

            cboCategory.Location = new Point(140, 20);
            cboCategory.Size = new Size(260, 28);
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Items.AddRange(new object[]
            {
                "Khám bệnh",
                "Xét nghiệm",
                "Chụp X-Quang",
                "Vắc-xin"
            });
            cboCategory.SelectedIndexChanged +=
                cboCategory_SelectedIndexChanged;

            lblAvailable.Text = "Dịch vụ có sẵn:";
            lblAvailable.Location = new Point(30, 75);
            lblAvailable.AutoSize = true;

            lstAvailableServices.Location = new Point(30, 105);
            lstAvailableServices.Size = new Size(300, 220);
            lstAvailableServices.DoubleClick +=
                lstAvailableServices_DoubleClick;

            btnSelect.Text = ">";
            btnSelect.Location = new Point(355, 140);
            btnSelect.Size = new Size(70, 40);
            btnSelect.Click += btnSelect_Click;

            btnRemove.Text = "<";
            btnRemove.Location = new Point(355, 190);
            btnRemove.Size = new Size(70, 40);
            btnRemove.Click += btnRemove_Click;

            btnClearAll.Text = "<<";
            btnClearAll.Location = new Point(355, 240);
            btnClearAll.Size = new Size(70, 40);
            btnClearAll.Click += btnClearAll_Click;

            lblSelected.Text = "Dịch vụ đã chọn:";
            lblSelected.Location = new Point(460, 75);
            lblSelected.AutoSize = true;

            lstSelectedServices.Location = new Point(460, 105);
            lstSelectedServices.Size = new Size(350, 220);

            lblTotal.Text = "Tổng tiền trước giảm:";
            lblTotal.Location = new Point(30, 365);
            lblTotal.AutoSize = true;

            lblTotalValue.Text = "0 đ";
            lblTotalValue.Location = new Point(220, 365);
            lblTotalValue.AutoSize = true;

            lblDiscount.Text = "Chiết khấu (%):";
            lblDiscount.Location = new Point(30, 405);
            lblDiscount.AutoSize = true;

            txtDiscount.Location = new Point(220, 400);
            txtDiscount.Size = new Size(100, 27);
            txtDiscount.Text = "0";
            txtDiscount.TextChanged += txtDiscount_TextChanged;

            lblDiscountValue.Text = "0 %";
            lblDiscountValue.Location = new Point(350, 405);
            lblDiscountValue.AutoSize = true;

            lblFinal.Text = "THÀNH TIỀN:";
            lblFinal.Location = new Point(460, 365);
            lblFinal.AutoSize = true;

            lblFinalValue.Text = "0 đ";
            lblFinalValue.Location = new Point(460, 405);
            lblFinalValue.AutoSize = true;

            Controls.Add(lblCategory);
            Controls.Add(cboCategory);
            Controls.Add(lblAvailable);
            Controls.Add(lstAvailableServices);
            Controls.Add(btnSelect);
            Controls.Add(btnRemove);
            Controls.Add(btnClearAll);
            Controls.Add(lblSelected);
            Controls.Add(lstSelectedServices);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalValue);
            Controls.Add(lblDiscount);
            Controls.Add(txtDiscount);
            Controls.Add(lblDiscountValue);
            Controls.Add(lblFinal);
            Controls.Add(lblFinalValue);

            ResumeLayout(false);
        }
    }
}