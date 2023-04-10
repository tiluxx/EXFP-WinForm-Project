
namespace WinForm_Project
{
    partial class AddProductForm
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
            this.productInfoGroup = new System.Windows.Forms.GroupBox();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.productSizeTxt = new System.Windows.Forms.TextBox();
            this.productBrandTxt = new System.Windows.Forms.TextBox();
            this.productQuanNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.productPriceNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productGrd = new System.Windows.Forms.DataGridView();
            this.productUnitSizeCB = new System.Windows.Forms.ComboBox();
            this.productOriginCB = new System.Windows.Forms.ComboBox();
            this.productIdTxt = new System.Windows.Forms.TextBox();
            this.productInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuanNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // productInfoGroup
            // 
            this.productInfoGroup.Controls.Add(this.productOriginCB);
            this.productInfoGroup.Controls.Add(this.productUnitSizeCB);
            this.productInfoGroup.Controls.Add(this.productPriceNum);
            this.productInfoGroup.Controls.Add(this.label6);
            this.productInfoGroup.Controls.Add(this.productQuanNum);
            this.productInfoGroup.Controls.Add(this.productBrandTxt);
            this.productInfoGroup.Controls.Add(this.productSizeTxt);
            this.productInfoGroup.Controls.Add(this.productNameTxt);
            this.productInfoGroup.Controls.Add(this.label5);
            this.productInfoGroup.Controls.Add(this.label4);
            this.productInfoGroup.Controls.Add(this.label3);
            this.productInfoGroup.Controls.Add(this.label2);
            this.productInfoGroup.Controls.Add(this.label1);
            this.productInfoGroup.Controls.Add(this.productNameLbl);
            this.productInfoGroup.Location = new System.Drawing.Point(12, 12);
            this.productInfoGroup.Name = "productInfoGroup";
            this.productInfoGroup.Size = new System.Drawing.Size(907, 84);
            this.productInfoGroup.TabIndex = 0;
            this.productInfoGroup.TabStop = false;
            this.productInfoGroup.Text = "Product information";
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Location = new System.Drawing.Point(6, 24);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(98, 17);
            this.productNameLbl.TabIndex = 0;
            this.productNameLbl.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(673, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Brand";
            // 
            // productNameTxt
            // 
            this.productNameTxt.Location = new System.Drawing.Point(110, 21);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(207, 22);
            this.productNameTxt.TabIndex = 6;
            // 
            // productSizeTxt
            // 
            this.productSizeTxt.Location = new System.Drawing.Point(110, 49);
            this.productSizeTxt.Name = "productSizeTxt";
            this.productSizeTxt.Size = new System.Drawing.Size(135, 22);
            this.productSizeTxt.TabIndex = 7;
            // 
            // productBrandTxt
            // 
            this.productBrandTxt.Location = new System.Drawing.Point(414, 21);
            this.productBrandTxt.Name = "productBrandTxt";
            this.productBrandTxt.Size = new System.Drawing.Size(207, 22);
            this.productBrandTxt.TabIndex = 8;
            // 
            // productQuanNum
            // 
            this.productQuanNum.Location = new System.Drawing.Point(740, 21);
            this.productQuanNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.productQuanNum.Name = "productQuanNum";
            this.productQuanNum.Size = new System.Drawing.Size(161, 22);
            this.productQuanNum.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(864, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "VND";
            // 
            // productPriceNum
            // 
            this.productPriceNum.Location = new System.Drawing.Point(740, 49);
            this.productPriceNum.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.productPriceNum.Name = "productPriceNum";
            this.productPriceNum.Size = new System.Drawing.Size(118, 22);
            this.productPriceNum.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productIdTxt);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.editBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(110, 21);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(95, 31);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(211, 21);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(95, 31);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(312, 21);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(95, 31);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(413, 21);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(95, 31);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(514, 21);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(95, 31);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productGrd);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 272);
            this.groupBox2.TabIndex = 2;
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
            this.productGrd.Size = new System.Drawing.Size(895, 245);
            this.productGrd.TabIndex = 0;
            this.productGrd.Click += new System.EventHandler(this.productGrd_Click);
            // 
            // productUnitSizeCB
            // 
            this.productUnitSizeCB.FormattingEnabled = true;
            this.productUnitSizeCB.Items.AddRange(new object[] {
            "m",
            "dm",
            "cm",
            "mm",
            "inches"});
            this.productUnitSizeCB.Location = new System.Drawing.Point(251, 49);
            this.productUnitSizeCB.Name = "productUnitSizeCB";
            this.productUnitSizeCB.Size = new System.Drawing.Size(66, 24);
            this.productUnitSizeCB.TabIndex = 3;
            // 
            // productOriginCB
            // 
            this.productOriginCB.FormattingEnabled = true;
            this.productOriginCB.Location = new System.Drawing.Point(414, 49);
            this.productOriginCB.Name = "productOriginCB";
            this.productOriginCB.Size = new System.Drawing.Size(207, 24);
            this.productOriginCB.TabIndex = 3;
            // 
            // productIdTxt
            // 
            this.productIdTxt.Location = new System.Drawing.Point(801, 21);
            this.productIdTxt.Name = "productIdTxt";
            this.productIdTxt.Size = new System.Drawing.Size(100, 22);
            this.productIdTxt.TabIndex = 5;
            this.productIdTxt.Visible = false;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.productInfoGroup);
            this.Name = "AddProductForm";
            this.Text = "Add Product Form";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.productInfoGroup.ResumeLayout(false);
            this.productInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuanNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox productInfoGroup;
        private System.Windows.Forms.NumericUpDown productPriceNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown productQuanNum;
        private System.Windows.Forms.TextBox productBrandTxt;
        private System.Windows.Forms.TextBox productSizeTxt;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView productGrd;
        private System.Windows.Forms.ComboBox productUnitSizeCB;
        private System.Windows.Forms.ComboBox productOriginCB;
        private System.Windows.Forms.TextBox productIdTxt;
    }
}