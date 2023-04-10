using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Project
{
    public partial class AddProductForm : Form
    {
        readonly String dbConn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        SqlConnection conn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        int btnType = 0;
        // btnType = 1 -> add btn
        // btnType = 2 -> edit btn

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            List<string> countryList = getCountryList();
            foreach(string country in countryList)
            {
                productOriginCB.Items.Add(country);
            }

            conn = new SqlConnection(dbConn);
            conn.Open();
            showGRD();
            formload();
        }

        private List<string> getCountryList()
        {
            List<string> countryList = new List<string>();
            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo getCulture in getCultureInfo)
            {
                RegionInfo getRegionInfo = new RegionInfo(getCulture.LCID);
                if (!countryList.Contains(getRegionInfo.EnglishName))
                {
                    countryList.Add(getRegionInfo.EnglishName);
                }
            }
            countryList.Sort();
            return countryList;
        }

        private string getRandomId()
        {
            Random res = new Random();
            String str = "abcdefghijklmnopqrstuvwxyz0123456789";
            int size = 10;

            String result = "";
            for (int i = 0; i < size; i++)
            {
                int x = res.Next(str.Length);
                result += str[x];
            }
            return result;
        }

        public void enableGRP(bool b, GroupBox grp)
        {
            grp.Enabled = b;
        }

        public void showGRD()
        {
            string sql = "select ItemID as ID, ItemName as 'Product Name', Size, UnitSize as 'Unit Size', Brand, Origin, Quantity, Price from Item";
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);
            productGrd.DataSource = tb;
        }

        public void formload()
        {
            enableGRP(false, productInfoGroup);
            addBtn.Enabled = true;
            deleteBtn.Enabled = false;
            editBtn.Enabled = false;
            saveBtn.Enabled = false;

            productIdTxt.Clear();
            productNameTxt.Clear();
            productSizeTxt.Clear();
            productBrandTxt.Clear();
            productOriginCB.ResetText();
            productQuanNum.Value = 0;
            productPriceNum.Value = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            btnType = 1;
            enableGRP(true, productInfoGroup);
            productIdTxt.Clear();
            productNameTxt.Clear();
            productSizeTxt.Clear();
            productBrandTxt.Clear();
            productOriginCB.ResetText();
            productQuanNum.Value = 0;
            productPriceNum.Value = 0;

            productNameTxt.Focus();
            deleteBtn.Enabled = false;
            editBtn.Enabled = false;
            saveBtn.Enabled = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            btnType = 2;
            enableGRP(true, productInfoGroup);
            productNameTxt.Focus();
            addBtn.Enabled = false;
            saveBtn.Enabled = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This delete action cannot undo!", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string inputProductId = productIdTxt.Text;
                if (inputProductId.Equals(""))
                {
                    MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "delete from Item where ItemID = '" + productIdTxt.Text + "'";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
                showGRD();
                formload();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string sql = "";
            string productName = productNameTxt.Text;
            string productSize = productSizeTxt.Text;
            string productUnitSize = productUnitSizeCB.SelectedItem != null ? productUnitSizeCB.SelectedItem.ToString() : "";
            string productBrand = productBrandTxt.Text;
            string productOrigin = productOriginCB.SelectedItem != null ? productOriginCB.SelectedItem.ToString() : "";
            int productQuan = (int)productQuanNum.Value;
            decimal productPrice = productPriceNum.Value;

            if (productName.Equals(""))
            {
                MessageBox.Show("Please enter a product name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (productSize.Equals(""))
            {
                MessageBox.Show("Please enter a product size", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (productUnitSize.Equals(""))
            {
                MessageBox.Show("Please choose an unit size", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (productBrand.Equals(""))
            {
                MessageBox.Show("Please enter a product brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (productOrigin.Equals(""))
            {
                MessageBox.Show("Please choose a product origin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnType == 1)
            {
                string productId = getRandomId();
                sql = "insert into Item values ('" + productId + "', '" + productName + "', '" + productSize + "', '" + productUnitSize + "', '" + productBrand + "', '" + productOrigin + "', " + productQuan + ", " + productPrice + ")";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
            }
            else if (btnType == 2)
            {
                string inputProductId = productIdTxt.Text;
                if (inputProductId.Equals(""))
                {
                    MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sql = "update Item set ItemName = '" + productName + "', Size = '" + productSize + "', UnitSize = '" + productUnitSize + "', Brand = '" + productBrand + "', Origin = '" + productOrigin + "', Quantity = " + productQuan + ", Price = " + productPrice + " where ItemID = '" + inputProductId + "'";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
            }
            showGRD();
            formload();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            formload();
        }

        private void productGrd_Click(object sender, EventArgs e)
        {
            productIdTxt.Text = productGrd.CurrentRow.Cells[0].Value.ToString();
            productNameTxt.Text = productGrd.CurrentRow.Cells[1].Value.ToString();
            productSizeTxt.Text = productGrd.CurrentRow.Cells[2].Value.ToString();
            productUnitSizeCB.Text = productGrd.CurrentRow.Cells[3].Value.ToString();
            productBrandTxt.Text = productGrd.CurrentRow.Cells[4].Value.ToString();
            productOriginCB.Text = productGrd.CurrentRow.Cells[5].Value.ToString();
            productQuanNum.Value = Convert.ToDecimal(productGrd.CurrentRow.Cells[6].Value.ToString());
            productPriceNum.Value = Convert.ToDecimal(productGrd.CurrentRow.Cells[7].Value.ToString());

            enableGRP(false, productInfoGroup);
            addBtn.Enabled = false;
            deleteBtn.Enabled = true;
            editBtn.Enabled = true;
            saveBtn.Enabled = false;
        }
    }
}
