
namespace WinForm_Project
{
    partial class OrderProductForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agentList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.changeProductQuanBtn = new System.Windows.Forms.Button();
            this.productIdTxt = new System.Windows.Forms.TextBox();
            this.productQuanUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.agentIdSelectedTxt = new System.Windows.Forms.TextBox();
            this.agentNameSelectedTxt = new System.Windows.Forms.TextBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.productOrderList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuanUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agentList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agent list";
            // 
            // agentList
            // 
            this.agentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agentList.Location = new System.Drawing.Point(6, 21);
            this.agentList.Name = "agentList";
            this.agentList.RowHeadersWidth = 51;
            this.agentList.RowTemplate.Height = 24;
            this.agentList.Size = new System.Drawing.Size(260, 399);
            this.agentList.TabIndex = 0;
            this.agentList.Click += new System.EventHandler(this.agentList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productCheckedListBox);
            this.groupBox2.Location = new System.Drawing.Point(290, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product list";
            // 
            // productCheckedListBox
            // 
            this.productCheckedListBox.FormattingEnabled = true;
            this.productCheckedListBox.Location = new System.Drawing.Point(6, 21);
            this.productCheckedListBox.Name = "productCheckedListBox";
            this.productCheckedListBox.Size = new System.Drawing.Size(356, 395);
            this.productCheckedListBox.TabIndex = 0;
            this.productCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.productCheckedListBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.changeProductQuanBtn);
            this.groupBox3.Controls.Add(this.productIdTxt);
            this.groupBox3.Controls.Add(this.productQuanUpDown);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.agentIdSelectedTxt);
            this.groupBox3.Controls.Add(this.agentNameSelectedTxt);
            this.groupBox3.Controls.Add(this.orderBtn);
            this.groupBox3.Controls.Add(this.productOrderList);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(664, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 426);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order detail";
            // 
            // changeProductQuanBtn
            // 
            this.changeProductQuanBtn.Location = new System.Drawing.Point(313, 164);
            this.changeProductQuanBtn.Name = "changeProductQuanBtn";
            this.changeProductQuanBtn.Size = new System.Drawing.Size(53, 23);
            this.changeProductQuanBtn.TabIndex = 15;
            this.changeProductQuanBtn.Text = "OK";
            this.changeProductQuanBtn.UseVisualStyleBackColor = true;
            this.changeProductQuanBtn.Click += new System.EventHandler(this.changeProductQuanBtn_Click);
            // 
            // productIdTxt
            // 
            this.productIdTxt.Location = new System.Drawing.Point(140, 164);
            this.productIdTxt.Name = "productIdTxt";
            this.productIdTxt.Size = new System.Drawing.Size(76, 22);
            this.productIdTxt.TabIndex = 14;
            this.productIdTxt.Visible = false;
            // 
            // productQuanUpDown
            // 
            this.productQuanUpDown.Location = new System.Drawing.Point(222, 164);
            this.productQuanUpDown.Name = "productQuanUpDown";
            this.productQuanUpDown.Size = new System.Drawing.Size(85, 22);
            this.productQuanUpDown.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 138);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(262, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Click a product row to edit order quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product Quantity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // agentIdSelectedTxt
            // 
            this.agentIdSelectedTxt.Location = new System.Drawing.Point(106, 81);
            this.agentIdSelectedTxt.Name = "agentIdSelectedTxt";
            this.agentIdSelectedTxt.Size = new System.Drawing.Size(260, 22);
            this.agentIdSelectedTxt.TabIndex = 9;
            // 
            // agentNameSelectedTxt
            // 
            this.agentNameSelectedTxt.Location = new System.Drawing.Point(106, 53);
            this.agentNameSelectedTxt.Name = "agentNameSelectedTxt";
            this.agentNameSelectedTxt.Size = new System.Drawing.Size(260, 22);
            this.agentNameSelectedTxt.TabIndex = 8;
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(137, 381);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(111, 35);
            this.orderBtn.TabIndex = 7;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // productOrderList
            // 
            this.productOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productOrderList.Location = new System.Drawing.Point(6, 192);
            this.productOrderList.Name = "productOrderList";
            this.productOrderList.RowHeadersWidth = 51;
            this.productOrderList.RowTemplate.Height = 24;
            this.productOrderList.Size = new System.Drawing.Size(360, 183);
            this.productOrderList.TabIndex = 6;
            this.productOrderList.Click += new System.EventHandler(this.productOrderList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Product ordered";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Agent ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agent name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agent information";
            // 
            // OrderProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderProductForm";
            this.Text = "OrderProductForm";
            this.Load += new System.EventHandler(this.OrderProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agentList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuanUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView agentList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox productCheckedListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.DataGridView productOrderList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox agentIdSelectedTxt;
        private System.Windows.Forms.TextBox agentNameSelectedTxt;
        private System.Windows.Forms.NumericUpDown productQuanUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productIdTxt;
        private System.Windows.Forms.Button changeProductQuanBtn;
    }
}