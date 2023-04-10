
namespace WinForm_Project
{
    partial class ProductViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewOptionsGrp = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.agentInfoTxt = new System.Windows.Forms.TextBox();
            this.mostPurchasedCustomerCheckBox = new System.Windows.Forms.RadioButton();
            this.bestSellingByCustomerCheckBox = new System.Windows.Forms.RadioButton();
            this.bestSellingCheckBox = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productGrd = new System.Windows.Forms.DataGridView();
            this.viewOptionsGrp.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // viewOptionsGrp
            // 
            this.viewOptionsGrp.Controls.Add(this.label1);
            this.viewOptionsGrp.Controls.Add(this.agentInfoTxt);
            this.viewOptionsGrp.Controls.Add(this.mostPurchasedCustomerCheckBox);
            this.viewOptionsGrp.Controls.Add(this.bestSellingByCustomerCheckBox);
            this.viewOptionsGrp.Controls.Add(this.bestSellingCheckBox);
            this.viewOptionsGrp.Location = new System.Drawing.Point(12, 12);
            this.viewOptionsGrp.Name = "viewOptionsGrp";
            this.viewOptionsGrp.Size = new System.Drawing.Size(915, 103);
            this.viewOptionsGrp.TabIndex = 0;
            this.viewOptionsGrp.TabStop = false;
            this.viewOptionsGrp.Text = "View options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter agent ID to find";
            // 
            // agentInfoTxt
            // 
            this.agentInfoTxt.Location = new System.Drawing.Point(250, 48);
            this.agentInfoTxt.Name = "agentInfoTxt";
            this.agentInfoTxt.Size = new System.Drawing.Size(168, 22);
            this.agentInfoTxt.TabIndex = 3;
            this.agentInfoTxt.TextChanged += new System.EventHandler(this.agentInfoTxt_TextChanged);
            // 
            // mostPurchasedCustomerCheckBox
            // 
            this.mostPurchasedCustomerCheckBox.AutoSize = true;
            this.mostPurchasedCustomerCheckBox.Location = new System.Drawing.Point(6, 75);
            this.mostPurchasedCustomerCheckBox.Name = "mostPurchasedCustomerCheckBox";
            this.mostPurchasedCustomerCheckBox.Size = new System.Drawing.Size(221, 21);
            this.mostPurchasedCustomerCheckBox.TabIndex = 2;
            this.mostPurchasedCustomerCheckBox.TabStop = true;
            this.mostPurchasedCustomerCheckBox.Text = "The most purchased customer";
            this.mostPurchasedCustomerCheckBox.UseVisualStyleBackColor = true;
            this.mostPurchasedCustomerCheckBox.CheckedChanged += new System.EventHandler(this.mostPurchasedCustomerCheckBox_CheckedChanged);
            // 
            // bestSellingByCustomerCheckBox
            // 
            this.bestSellingByCustomerCheckBox.AutoSize = true;
            this.bestSellingByCustomerCheckBox.Location = new System.Drawing.Point(6, 48);
            this.bestSellingByCustomerCheckBox.Name = "bestSellingByCustomerCheckBox";
            this.bestSellingByCustomerCheckBox.Size = new System.Drawing.Size(238, 21);
            this.bestSellingByCustomerCheckBox.TabIndex = 1;
            this.bestSellingByCustomerCheckBox.TabStop = true;
            this.bestSellingByCustomerCheckBox.Text = "The best-selling item of customer";
            this.bestSellingByCustomerCheckBox.UseVisualStyleBackColor = true;
            this.bestSellingByCustomerCheckBox.CheckedChanged += new System.EventHandler(this.bestSellingByCustomerCheckBox_CheckedChanged);
            // 
            // bestSellingCheckBox
            // 
            this.bestSellingCheckBox.AutoSize = true;
            this.bestSellingCheckBox.Location = new System.Drawing.Point(6, 21);
            this.bestSellingCheckBox.Name = "bestSellingCheckBox";
            this.bestSellingCheckBox.Size = new System.Drawing.Size(160, 21);
            this.bestSellingCheckBox.TabIndex = 0;
            this.bestSellingCheckBox.TabStop = true;
            this.bestSellingCheckBox.Text = "The best-selling item";
            this.bestSellingCheckBox.UseVisualStyleBackColor = true;
            this.bestSellingCheckBox.CheckedChanged += new System.EventHandler(this.bestSellingCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productGrd);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(915, 317);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product list";
            // 
            // productGrd
            // 
            this.productGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrd.Location = new System.Drawing.Point(6, 21);
            this.productGrd.Name = "productGrd";
            this.productGrd.RowHeadersWidth = 51;
            this.productGrd.RowTemplate.Height = 24;
            this.productGrd.Size = new System.Drawing.Size(903, 290);
            this.productGrd.TabIndex = 0;
            // 
            // ProductViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.viewOptionsGrp);
            this.Name = "ProductViewForm";
            this.Text = "Products View Form";
            this.Load += new System.EventHandler(this.ProductViewForm_Load);
            this.viewOptionsGrp.ResumeLayout(false);
            this.viewOptionsGrp.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox viewOptionsGrp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox agentInfoTxt;
        private System.Windows.Forms.RadioButton mostPurchasedCustomerCheckBox;
        private System.Windows.Forms.RadioButton bestSellingByCustomerCheckBox;
        private System.Windows.Forms.RadioButton bestSellingCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView productGrd;
    }
}