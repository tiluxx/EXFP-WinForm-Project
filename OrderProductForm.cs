using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Project
{
    public partial class OrderProductForm : Form
    {
        readonly String dbConn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        SqlConnection conn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;

        public OrderProductForm()
        {
            InitializeComponent();
        }

        private void OrderProductForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbConn);
            conn.Open();
            showAgentGRD(agentList);
            showProductCheckListBox();
        }

        public void showAgentGRD(DataGridView grd)
        {
            string sql = "select AgenID as ID, AgentName as 'Agent Name', Address from Agent";
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        public void showProductCheckListBox()
        {
            string sql = "select * from Item";
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);

            // get product data
            List<string> productList = new List<string> {};
            foreach (DataRow dbRow in tb.Rows)
            {
                List<string> productDataRow = new List<string> {};
                foreach (DataColumn dbCol in tb.Columns)
                {
                    productDataRow.Add(dbRow[dbCol].ToString());
                }
                string productData = productDataRow[0] + "-" + productDataRow[1];
                productList.Add(productData);
            }

            // add to check list box
            foreach (string data in productList)
            {
                productCheckedListBox.Items.Add(data);
            }
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

        private void productCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable productOrderTb = new DataTable();
            productOrderTb.Columns.Add("ID");
            productOrderTb.Columns.Add("Product name");
            productOrderTb.Columns.Add("Quantity");

            foreach (var product in productCheckedListBox.CheckedItems)
            {
                string productData = product.ToString();
                string[] productDataLst = productData.Split('-');

                DataRow row = productOrderTb.NewRow();
                row["ID"] = productDataLst[0];
                row["Product name"] = productDataLst[1];
                row["Quantity"] = 1;
                productOrderTb.Rows.Add(row);
            }

            productOrderList.DataSource = productOrderTb;
        }

        private void agentList_Click(object sender, EventArgs e)
        {
            agentIdSelectedTxt.Text = agentList.CurrentRow.Cells[0].Value.ToString();
            agentNameSelectedTxt.Text = agentList.CurrentRow.Cells[1].Value.ToString();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (agentIdSelectedTxt.Text.Equals(""))
            {
                MessageBox.Show("Please choose an agent", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (productCheckedListBox.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Please choose a product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string orderId = getRandomId();
            string agentId = agentIdSelectedTxt.Text;

            string sql = "insert into _Order values ('" + orderId + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + agentId + "')";
            cm = new SqlCommand(sql, conn);
            cm.ExecuteNonQuery();

            int tbRowCount = productOrderList.Rows.Count - 1;
            for (int i = 0; i < tbRowCount; ++i)
            {
                string orderDetailId = getRandomId();
                string productIdOrder = productOrderList.Rows[i].Cells[0].Value.ToString();
                decimal productQuanOrder = Convert.ToDecimal(productOrderList.Rows[i].Cells[2].Value.ToString());
                sql = "insert into OrderDetail values ('" + orderDetailId + "', '" + orderId + "', '" + productIdOrder + "', '" + productQuanOrder + "', 'Product')";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();

                decimal newQuan = getProductQuanInStock(productIdOrder) - productQuanOrder;
                sql = "update Item set Quantity = " + newQuan;
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();

                MessageBox.Show("Add order successfully");
            }
        }

        private void productOrderList_Click(object sender, EventArgs e)
        {
            productIdTxt.Text = productOrderList.CurrentRow.Cells[0].Value.ToString();
            productQuanUpDown.Value = Convert.ToDecimal(productOrderList.CurrentRow.Cells[2].Value.ToString());
        }

        private decimal getProductQuanInStock(string productId)
        {
            string sql = "select Quantity from Item where ItemID = '" + productId + "'";
            data = new SqlDataAdapter(sql, conn);
            DataTable res = new DataTable();
            data.Fill(res);

            return Convert.ToDecimal(res.Rows[0][0].ToString());
        }

        private void changeProductQuanBtn_Click(object sender, EventArgs e)
        {
            decimal productQuanVal = productQuanUpDown.Value;
            if (productQuanVal <= 0)
            {
                productQuanUpDown.Value = 1;
                return;
            }

            if (productIdTxt.Text.Equals("") || productIdTxt == null)
            {
                return;
            }

            if (getProductQuanInStock(productIdTxt.Text) < productQuanVal)
            {
                MessageBox.Show("Product is not enough in the stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tbRowCount = productOrderList.Rows.Count;
            for (int i = 0; i < tbRowCount; ++i)
            {
                if (productOrderList.Rows[i].Cells[0].Value.ToString() == productIdTxt.Text)
                {
                    productOrderList.Rows[i].Cells[2].Value = productQuanVal;
                    return;
                }
            }
        }
    }
}
