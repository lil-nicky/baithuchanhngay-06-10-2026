using System;
using System.Windows.Forms;

namespace Bai51
{
    public partial class Form51 : Form
    {
        public Form51()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            epCheck.Clear();

            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Vui lòng nhập tên tài khoản.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Vui lòng nhập mật khẩu.");
                valid = false;
            }

            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                epCheck.SetError(
                    txtConfirmPassword,
                    "Mật khẩu xác nhận không khớp.");
                valid = false;
            }

            int age = DateTime.Now.Year - dtpBirthDate.Value.Year;

            if (dtpBirthDate.Value.Date > DateTime.Now.AddYears(-age).Date)
                age--;

            if (age < 18)
            {
                epCheck.SetError(
                    dtpBirthDate,
                    "Tài khoản phải từ 18 tuổi trở lên.");
                valid = false;
            }

            if (!rbMale.Checked && !rbFemale.Checked)
            {
                epCheck.SetError(
                    grpGender,
                    "Vui lòng chọn giới tính.");
                valid = false;
            }

            if (!chkTerms.Checked)
            {
                epCheck.SetError(
                    chkTerms,
                    "Bạn phải đồng ý với điều khoản.");
                valid = false;
            }

            if (valid)
            {
                string gender = rbMale.Checked ? "Nam" : "Nữ";

                MessageBox.Show(
                    $"Đăng ký thành công!\n\n" +
                    $"Tài khoản: {txtUsername.Text}\n" +
                    $"Ngày sinh: {dtpBirthDate.Value:dd/MM/yyyy}\n" +
                    $"Giới tính: {gender}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            dtpBirthDate.Value = DateTime.Now.AddYears(-18);

            rbMale.Checked = false;
            rbFemale.Checked = false;
            chkTerms.Checked = false;

            epCheck.Clear();
            txtUsername.Focus();
        }
    }
}