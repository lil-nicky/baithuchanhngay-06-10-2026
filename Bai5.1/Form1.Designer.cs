namespace Bai51
{
    partial class Form51
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.GroupBox grpAdditional;
        private System.Windows.Forms.GroupBox grpGender;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblBirthDate;

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;

        private System.Windows.Forms.DateTimePicker dtpBirthDate;

        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;

        private System.Windows.Forms.CheckBox chkTerms;

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.ErrorProvider epCheck;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            grpAccount = new GroupBox();
            grpAdditional = new GroupBox();
            grpGender = new GroupBox();

            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblBirthDate = new Label();

            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();

            dtpBirthDate = new DateTimePicker();

            rbMale = new RadioButton();
            rbFemale = new RadioButton();

            chkTerms = new CheckBox();

            btnRegister = new Button();
            btnReset = new Button();

            epCheck = new ErrorProvider(components);

            SuspendLayout();

            // Form
            Text = "Đăng ký tài khoản";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(600, 470);
            MinimumSize = new Size(550, 430);

            // Account Group
            grpAccount.Text = "Thông tin tài khoản";
            grpAccount.Location = new Point(30, 25);
            grpAccount.Size = new Size(540, 190);

            lblUsername.Text = "Tên tài khoản:";
            lblUsername.Location = new Point(25, 35);
            lblUsername.AutoSize = true;

            txtUsername.Location = new Point(170, 32);
            txtUsername.Size = new Size(330, 27);

            lblPassword.Text = "Mật khẩu:";
            lblPassword.Location = new Point(25, 80);
            lblPassword.AutoSize = true;

            txtPassword.Location = new Point(170, 77);
            txtPassword.Size = new Size(330, 27);
            txtPassword.UseSystemPasswordChar = true;

            lblConfirmPassword.Text = "Xác nhận mật khẩu:";
            lblConfirmPassword.Location = new Point(25, 125);
            lblConfirmPassword.AutoSize = true;

            txtConfirmPassword.Location = new Point(170, 122);
            txtConfirmPassword.Size = new Size(330, 27);
            txtConfirmPassword.UseSystemPasswordChar = true;

            grpAccount.Controls.Add(lblUsername);
            grpAccount.Controls.Add(txtUsername);
            grpAccount.Controls.Add(lblPassword);
            grpAccount.Controls.Add(txtPassword);
            grpAccount.Controls.Add(lblConfirmPassword);
            grpAccount.Controls.Add(txtConfirmPassword);

            // Additional Group
            grpAdditional.Text = "Thông tin bổ sung";
            grpAdditional.Location = new Point(30, 230);
            grpAdditional.Size = new Size(540, 145);

            lblBirthDate.Text = "Ngày sinh:";
            lblBirthDate.Location = new Point(25, 32);
            lblBirthDate.AutoSize = true;

            dtpBirthDate.Location = new Point(170, 29);
            dtpBirthDate.Size = new Size(220, 27);
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Value = DateTime.Now.AddYears(-18);

            grpGender.Text = "Giới tính";
            grpGender.Location = new Point(25, 70);
            grpGender.Size = new Size(250, 55);

            rbMale.Text = "Nam";
            rbMale.Location = new Point(20, 20);
            rbMale.AutoSize = true;

            rbFemale.Text = "Nữ";
            rbFemale.Location = new Point(120, 20);
            rbFemale.AutoSize = true;

            grpGender.Controls.Add(rbMale);
            grpGender.Controls.Add(rbFemale);

            chkTerms.Text = "Tôi đồng ý với các điều khoản sử dụng";
            chkTerms.Location = new Point(300, 90);
            chkTerms.AutoSize = true;

            grpAdditional.Controls.Add(lblBirthDate);
            grpAdditional.Controls.Add(dtpBirthDate);
            grpAdditional.Controls.Add(grpGender);
            grpAdditional.Controls.Add(chkTerms);

            // Buttons
            btnRegister.Text = "Đăng Ký";
            btnRegister.Location = new Point(180, 395);
            btnRegister.Size = new Size(110, 40);
            btnRegister.Click += btnRegister_Click;

            btnReset.Text = "Làm Mới";
            btnReset.Location = new Point(310, 395);
            btnReset.Size = new Size(110, 40);
            btnReset.Click += btnReset_Click;

            Controls.Add(grpAccount);
            Controls.Add(grpAdditional);
            Controls.Add(btnRegister);
            Controls.Add(btnReset);

            ResumeLayout(false);
        }
    }
}