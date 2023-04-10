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
    public partial class AddAgentForm : Form
    {
        readonly String dbConn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        SqlConnection conn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        int btnType = 0;
        // btnType = 1 -> add btn
        // btnType = 2 -> edit btn

        public AddAgentForm()
        {
            InitializeComponent();
        }

        private void AddAgentForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbConn);
            conn.Open();
            showGRD();
            formload();
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
            string sql = "select AgenID as ID, AgentName as 'Agent Name', Address from Agent";
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);
            agentGrd.DataSource = tb;
            agentIdTxt.Enabled = false;
        }

        public void formload()
        {
            enableGRP(false, agentInfoGroup);
            addBtn.Enabled = true;
            deleteBtn.Enabled = false;
            editBtn.Enabled = false;
            saveBtn.Enabled = false;

            agentIdTxt.Enabled = false;
            agentIdTxt.Clear();
            agentNameTxt.Clear();
            agentAddressTxt.Clear();
            agentAddressTxt.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            btnType = 1;
            enableGRP(true, agentInfoGroup);
            agentIdTxt.Clear();
            agentNameTxt.Clear();
            agentAddressTxt.Clear();

            agentIdTxt.Enabled = false;
            agentNameTxt.Focus();
            deleteBtn.Enabled = false;
            editBtn.Enabled = false;
            saveBtn.Enabled = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            btnType = 2;
            enableGRP(true, agentInfoGroup);
            agentNameTxt.Focus();
            addBtn.Enabled = false;
            saveBtn.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string sql = "";
            string agentName = agentNameTxt.Text;
            string agentAddress = agentAddressTxt.Text;

            if (agentName.Equals(""))
            {
                MessageBox.Show("Please enter an agent name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (agentAddress.Equals(""))
            {
                MessageBox.Show("Please enter an agent address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnType == 1)
            {
                string agentId = getRandomId();
                sql = "insert into Agent values ('" + agentId + "', '" + agentName + "', '" + agentAddress + "')";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
            }
            else if (btnType == 2)
            {
                string inputAgentId = agentIdTxt.Text;
                if (inputAgentId.Equals(""))
                {
                    MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sql = "update Agent set AgentName = '" + agentName + "', Address = '" + agentAddress + "' where AgenID = '" + inputAgentId + "'";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
            }
            showGRD();
            formload();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This delete action cannot undo!", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string inputAgentId = agentIdTxt.Text;
                if (inputAgentId.Equals(""))
                {
                    MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "delete from Agent where AgenID = '" + inputAgentId + "'";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
                showGRD();
                formload();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            formload();
        }

        private void agentGrd_Click(object sender, EventArgs e)
        {
            agentIdTxt.Text = agentGrd.CurrentRow.Cells[0].Value.ToString();
            agentNameTxt.Text = agentGrd.CurrentRow.Cells[1].Value.ToString();
            agentAddressTxt.Text = agentGrd.CurrentRow.Cells[2].Value.ToString();

            enableGRP(false, agentInfoGroup);
            addBtn.Enabled = false;
            deleteBtn.Enabled = true;
            editBtn.Enabled = true;
            saveBtn.Enabled = false;
        }
    }
}
