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
    public partial class ProductViewForm : Form
    {
        readonly String dbConn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        SqlConnection conn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;

        public ProductViewForm()
        {
            InitializeComponent();
        }

        private void ProductViewForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbConn);
            conn.Open();
            agentInfoTxt.Enabled = false;
        }

        void showGRD(string sql)
        {
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);
            productGrd.DataSource = tb;
        }

        private void bestSellingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bestSellingCheckBox.Checked)
            {
                agentInfoTxt.Clear();
                agentInfoTxt.Enabled = false;
                string sql = "select I1.ItemID as ID, I1.ItemName as 'Product name', I1.Size, I1.UnitSize as 'Unit size', I1.Brand, I1.Origin, I1.Price, sum(O1.Quantity) as 'Selling amount'" + 
                        " from Item I1, OrderDetail O1" +
                        " where I1.ItemID = O1.ItemID" +
                        " group by I1.ItemID, I1.ItemID, I1.ItemName, I1.Size, I1.UnitSize, I1.Brand, I1.Origin, I1.Price" +
                        " having sum(O1.Quantity) >= all(" +
                            " select sum(O2.Quantity)" +
                            " from Item I2, OrderDetail O2" +
                            " where I2.ItemID = O2.ItemID" +
                            " group by I2.ItemID)";
                showGRD(sql);
            }
        }

        private void bestSellingByCustomerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bestSellingByCustomerCheckBox.Checked)
            {
                agentInfoTxt.Enabled = true;
            }
        }

        private void mostPurchasedCustomerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mostPurchasedCustomerCheckBox.Checked)
            {
                agentInfoTxt.Clear();
                agentInfoTxt.Enabled = false;
                string sql = "select A.AgenID as ID, A.AgentName as 'Agent Name', A.Address, sum(OD.Quantity) as 'Purchase quantity'" +
                        " from Item I, OrderDetail OD, _Order O, Agent A" +
                        " where O.OrderID = OD.OrderID and I.ItemID = OD.ItemID and A.AgenID = O.AgentID" +
                        " group by A.AgenID, A.AgentName, A.Address" +
                        " having sum(OD.Quantity) >= all(" +
                            " select sum(OD1.Quantity)" +
                            " from Item I1, OrderDetail OD1, _Order O1" +
                            " where O1.OrderID = OD1.OrderID and I1.ItemID = OD1.ItemID group by O1.AgentID)";
                showGRD(sql);
            }
        }

        private void agentInfoTxt_TextChanged(object sender, EventArgs e)
        {
            if (bestSellingByCustomerCheckBox.Checked)
            {
                string sql = "select I1.ItemID as ID, I1.ItemName as 'Product name', I1.Size, I1.UnitSize as 'Unit size', I1.Brand, I1.Origin, I1.Price, sum(OD1.Quantity) as 'Selling amount'" + 
                    " from Item I1, OrderDetail OD1, _Order O" +
                    " where O.OrderID = OD1.OrderID and O.AgentID = '" + agentInfoTxt.Text + "' and I1.ItemID = OD1.ItemID" +
                    " group by I1.ItemID, I1.ItemName, I1.Size, I1.UnitSize, I1.Brand, I1.Origin, I1.Price" +
                    " having sum(OD1.Quantity) >= all(" +
                        " select sum(OD2.Quantity)" +
                        " from Item I2, OrderDetail OD2, _Order O1" +
                        " where O1.OrderID = OD2.OrderID and O1.AgentID = '" + agentInfoTxt.Text + "' and I2.ItemID = OD2.ItemID group by I2.ItemID)";
                showGRD(sql);
            }
        }
    }
}
