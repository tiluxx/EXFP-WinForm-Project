using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Project
{
    public partial class MainForm : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void productManagementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.MdiParent = this;
            addProductForm.Show();
        }

        private void agentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAgentForm addAgentForm = new AddAgentForm();
            addAgentForm.MdiParent = this;
            addAgentForm.Show();
        }

        private void orderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderProductForm orderProductForm = new OrderProductForm();
            orderProductForm.MdiParent = this;
            orderProductForm.Show();
        }

        private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewOrderForm viewOrderForm = new ViewOrderForm();
            viewOrderForm.MdiParent = this;
            viewOrderForm.Show();
        }

        private void productsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductViewForm viewProductForm = new ProductViewForm();
            viewProductForm.MdiParent = this;
            viewProductForm.Show();
        }
    }
}
