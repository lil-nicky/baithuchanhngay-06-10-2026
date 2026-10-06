using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bai54
{
    public partial class Form54 : Form
    {
        private List<Employee> employees = new List<Employee>();

        public Form54()
        {
            InitializeComponent();

            CreateImageList();
            CreateEmployeeData();
            CreateTree();

            cboViewMode.SelectedIndex = 0;

            LoadEmployees(employees);
        }

        // =========================
        // CLASS NHÂN VIÊN
        // =========================
        private class Employee
        {
            public string MaNV { get; set; }
            public string HoTen { get; set; }
            public string ChucVu { get; set; }
            public DateTime NgayVao { get; set; }
            public string PhongBan { get; set; }
            public string Nhom { get; set; }

            public Employee(
                string maNV,
                string hoTen,
                string chucVu,
                DateTime ngayVao,
                string phongBan,
                string nhom)
            {
                MaNV = maNV;
                HoTen = hoTen;
                ChucVu = chucVu;
                NgayVao = ngayVao;
                PhongBan = phongBan;
                Nhom = nhom;
            }
        }

        // =========================
        // TẠO DỮ LIỆU NHÂN VIÊN
        // =========================
        private void CreateEmployeeData()
        {
            employees.Add(new Employee(
                "NV001",
                "Nguyễn Văn An",
                "Trưởng phòng",
                new DateTime(2022, 2, 1),
                "Kinh doanh",
                "Nhóm A"));

            employees.Add(new Employee(
                "NV002",
                "Trần Văn Bình",
                "Nhân viên",
                new DateTime(2023, 3, 15),
                "Kinh doanh",
                "Nhóm A"));

            employees.Add(new Employee(
                "NV003",
                "Lê Thị Hoa",
                "Nhân viên",
                new DateTime(2023, 6, 20),
                "Kinh doanh",
                "Nhóm B"));

            employees.Add(new Employee(
                "NV004",
                "Phạm Văn Nam",
                "Trưởng phòng",
                new DateTime(2021, 1, 10),
                "Kỹ thuật",
                "Nhóm A"));

            employees.Add(new Employee(
                "NV005",
                "Đỗ Minh Quân",
                "Lập trình viên",
                new DateTime(2024, 5, 12),
                "Kỹ thuật",
                "Nhóm A"));

            employees.Add(new Employee(
                "NV006",
                "Hoàng Thị Mai",
                "Tester",
                new DateTime(2024, 8, 18),
                "Kỹ thuật",
                "Nhóm B"));
            employees.Add(new Employee(
                            "NV007",
                            "Nguyễn Thị Lan",
                            "Kế toán trưởng",
                            new DateTime(2020, 4, 5),
                            "Tài chính",
                            "Nhóm A"));

            employees.Add(new Employee(
                "NV008",
                "Vũ Văn Sơn",
                "Kế toán",
                new DateTime(2023, 9, 22),
                "Tài chính",
                "Nhóm B"));
        }

        // =========================
        // TẠO CÂY TREEVIEW
        // =========================
        private void CreateTree()
        {
            tvDepartments.Nodes.Clear();

            TreeNode root = new TreeNode("Công ty ABC");
            root.ImageIndex = 0;
            root.SelectedImageIndex = 0;

            // PHÒNG KINH DOANH
            TreeNode kinhDoanh = new TreeNode("Kinh doanh");
            kinhDoanh.ImageIndex = 1;
            kinhDoanh.SelectedImageIndex = 1;

            TreeNode kdA = new TreeNode("Nhóm A");
            kdA.ImageIndex = 2;
            kdA.SelectedImageIndex = 2;

            TreeNode kdB = new TreeNode("Nhóm B");
            kdB.ImageIndex = 2;
            kdB.SelectedImageIndex = 2;

            kinhDoanh.Nodes.Add(kdA);
            kinhDoanh.Nodes.Add(kdB);

            // PHÒNG KỸ THUẬT
            TreeNode kyThuat = new TreeNode("Kỹ thuật");
            kyThuat.ImageIndex = 1;
            kyThuat.SelectedImageIndex = 1;

            TreeNode ktA = new TreeNode("Nhóm A");
            ktA.ImageIndex = 2;
            ktA.SelectedImageIndex = 2;

            TreeNode ktB = new TreeNode("Nhóm B");
            ktB.ImageIndex = 2;
            ktB.SelectedImageIndex = 2;

            kyThuat.Nodes.Add(ktA);
            kyThuat.Nodes.Add(ktB);

            // PHÒNG TÀI CHÍNH
            TreeNode taiChinh = new TreeNode("Tài chính");
            taiChinh.ImageIndex = 1;
            taiChinh.SelectedImageIndex = 1;

            TreeNode tcA = new TreeNode("Nhóm A");
            tcA.ImageIndex = 2;
            tcA.SelectedImageIndex = 2;

            TreeNode tcB = new TreeNode("Nhóm B");
            tcB.ImageIndex = 2;
            tcB.SelectedImageIndex = 2;

            taiChinh.Nodes.Add(tcA);
            taiChinh.Nodes.Add(tcB);

            root.Nodes.Add(kinhDoanh);
            root.Nodes.Add(kyThuat);
            root.Nodes.Add(taiChinh);

            tvDepartments.Nodes.Add(root);

            // Mở cây khi chạy chương trình
            root.Expand();
            kinhDoanh.Expand();
            kyThuat.Expand();
            taiChinh.Expand();
        }

        // =========================
        // IMAGE LIST
        // =========================
        private void CreateImageList()
        {
            ImageList images = new ImageList();

            images.ImageSize = new Size(16, 16);
            images.ColorDepth = ColorDepth.Depth32Bit;

            // Icon công ty
            Bitmap companyIcon = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(companyIcon))
            {
                g.Clear(Color.White);
                using (Brush brush = new SolidBrush(Color.SteelBlue))
                {
                    g.FillRectangle(brush, 2, 4, 12, 10);
                }

                using (Brush brush = new SolidBrush(Color.White))
                {
                    g.FillRectangle(brush, 5, 7, 2, 2);
                    g.FillRectangle(brush, 9, 7, 2, 2);
                }
            }

            // Icon phòng ban
            Bitmap departmentIcon = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(departmentIcon))
            {
                g.Clear(Color.White);
                using (Brush brush = new SolidBrush(Color.Goldenrod))
                {
                    g.FillRectangle(brush, 2, 4, 12, 9);
                    g.FillRectangle(brush, 4, 2, 5, 3);
                }
            }

            // Icon nhóm
            Bitmap groupIcon = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(groupIcon))
            {
                g.Clear(Color.White);
                using (Brush brush = new SolidBrush(Color.SeaGreen))
                {
                    g.FillRectangle(brush, 3, 3, 10, 10);
                }
            }

            images.Images.Add(companyIcon);
            images.Images.Add(departmentIcon);
            images.Images.Add(groupIcon);

            tvDepartments.ImageList = images;
        }

        // =========================
        // LOAD NHÂN VIÊN
        // =========================
        private void LoadEmployees(List<Employee> data)
        {
            lsvEmployees.Items.Clear();

            foreach (Employee employee in data)
            {
                ListViewItem item = new ListViewItem(employee.MaNV);

                item.SubItems.Add(employee.HoTen);
                item.SubItems.Add(employee.ChucVu);
                item.SubItems.Add(employee.NgayVao.ToString("dd/MM/yyyy"));

                // icon nhân viên
                item.ImageIndex = 2;

                // lưu object nhân viên vào Tag
                item.Tag = employee;

                lsvEmployees.Items.Add(item);
            }
        }

        // =========================
        // CLICK NODE TREEVIEW
        // =========================
        private void tvDepartments_AfterSelect(
            object sender,
            TreeViewEventArgs e)
        {
            TreeNode node = e.Node;

            // Công ty
            if (node.Level == 0)
            {
                LoadEmployees(employees);
                return;
            }

            // Phòng ban
            if (node.Level == 1)
            {
                string department = node.Text;

                List<Employee> result = employees
                    .Where(x => x.PhongBan == department)
                    .ToList();
                LoadEmployees(result);
                return;
            }

            // Nhóm
            if (node.Level == 2)
            {
                string group = node.Text;
                string department = node.Parent.Text;

                List<Employee> result = employees
                    .Where(x =>
                        x.PhongBan == department &&
                        x.Nhom == group)
                    .ToList();

                LoadEmployees(result);
            }
        }

        // =========================
        // ĐỔI CHẾ ĐỘ HIỂN THỊ
        // =========================
        private void cboViewMode_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            switch (cboViewMode.SelectedIndex)
            {
                case 0:
                    // Details
                    lsvEmployees.View = View.Details;
                    break;

                case 1:
                    // SmallIcon
                    lsvEmployees.View = View.SmallIcon;
                    break;
                case 2:

                    // LargeIcon

                    lsvEmployees.View = View.LargeIcon;

                    break;

                case 3:

                    // Tile

                    lsvEmployees.View = View.Tile;

                    break;

            }

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }

}