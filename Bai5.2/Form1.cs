using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Bai52
{
    public partial class Form52 : Form
    {
        private readonly Dictionary<string, List<string>> services =
            new Dictionary<string, List<string>>
            {
                {
                    "Khám bệnh",
                    new List<string>
                    {
                        "Khám tổng quát - 150000",
                        "Khám chuyên khoa - 250000",
                        "Khám nhi - 180000"
                    }
                },
                {
                    "Xét nghiệm",
                    new List<string>
                    {
                        "Xét nghiệm máu - 120000",
                        "Xét nghiệm nước tiểu - 80000",
                        "Xét nghiệm đường huyết - 70000"
                    }
                },
                {
                    "Chụp X-Quang",
                    new List<string>
                    {
                        "X-Quang phổi - 200000",
                        "X-Quang xương - 180000"
                    }
                },
                {
                    "Vắc-xin",
                    new List<string>
                    {
                        "Vắc-xin cúm - 300000",
                        "Vắc-xin viêm gan B - 250000",
                        "Vắc-xin HPV - 1500000"
                    }
                }
            };

        public Form52()
        {
            InitializeComponent();

            cboCategory.SelectedIndex = 0;
            LoadServices();
            CalculateTotal();
        }

        private void cboCategory_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            LoadServices();
        }

        private void LoadServices()
        {
            lstAvailableServices.Items.Clear();

            if (cboCategory.SelectedItem == null)
                return;

            string category = cboCategory.SelectedItem.ToString();

            foreach (string service in services[category])
                lstAvailableServices.Items.Add(service);
        }

        private decimal GetPrice(string service)
        {
            int index = service.LastIndexOf('-');

            if (index == -1)
                return 0;

            string price = service.Substring(index + 1).Trim();

            decimal.TryParse(
                price,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out decimal result);

            return result;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstAvailableServices.SelectedItem == null)
                return;

            string item = lstAvailableServices.SelectedItem.ToString();

            if (!lstSelectedServices.Items.Contains(item))
                lstSelectedServices.Items.Add(item);

            CalculateTotal();
        }

        private void lstAvailableServices_DoubleClick(
            object sender, EventArgs e)
        {
            btnSelect_Click(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Remove(
                    lstSelectedServices.SelectedItem);

                CalculateTotal();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            CalculateTotal();
        }

        private void txtDiscount_TextChanged(
            object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = 0;

            foreach (object item in lstSelectedServices.Items)
                total += GetPrice(item.ToString());

            decimal discount = 0;

            if (decimal.TryParse(txtDiscount.Text, out decimal value))
            {
                if (value >= 0 && value <= 100)
                    discount = value;
            }

            decimal finalPrice = total - total * discount / 100;

            lblTotalValue.Text = total.ToString("N0") + " đ";
            lblDiscountValue.Text = discount.ToString("0.##") + " %";
            lblFinalValue.Text = finalPrice.ToString("N0") + " đ";
        }
    }
}