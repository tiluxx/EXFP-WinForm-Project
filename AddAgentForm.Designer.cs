
namespace WinForm_Project
{
    partial class AddAgentForm
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
            this.agentGrd = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.agentAddressTxt = new System.Windows.Forms.TextBox();
            this.agentNameTxt = new System.Windows.Forms.TextBox();
            this.agentIdTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.agentInfoGroup = new System.Windows.Forms.GroupBox();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.agentGrd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.agentInfoGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // agentGrd
            // 
            this.agentGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agentGrd.Location = new System.Drawing.Point(6, 21);
            this.agentGrd.Name = "agentGrd";
            this.agentGrd.RowHeadersWidth = 51;
            this.agentGrd.RowTemplate.Height = 24;
            this.agentGrd.Size = new System.Drawing.Size(783, 292);
            this.agentGrd.TabIndex = 0;
            this.agentGrd.Click += new System.EventHandler(this.agentGrd_Click);
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
            // agentAddressTxt
            // 
            this.agentAddressTxt.Location = new System.Drawing.Point(469, 19);
            this.agentAddressTxt.Name = "agentAddressTxt";
            this.agentAddressTxt.Size = new System.Drawing.Size(320, 22);
            this.agentAddressTxt.TabIndex = 8;
            // 
            // agentNameTxt
            // 
            this.agentNameTxt.Location = new System.Drawing.Point(99, 49);
            this.agentNameTxt.Name = "agentNameTxt";
            this.agentNameTxt.Size = new System.Drawing.Size(229, 22);
            this.agentNameTxt.TabIndex = 7;
            // 
            // agentIdTxt
            // 
            this.agentIdTxt.Location = new System.Drawing.Point(99, 21);
            this.agentIdTxt.Name = "agentIdTxt";
            this.agentIdTxt.Size = new System.Drawing.Size(229, 22);
            this.agentIdTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Agent Address";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agent ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.agentGrd);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 319);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agent list";
            // 
            // agentInfoGroup
            // 
            this.agentInfoGroup.Controls.Add(this.agentAddressTxt);
            this.agentInfoGroup.Controls.Add(this.agentNameTxt);
            this.agentInfoGroup.Controls.Add(this.agentIdTxt);
            this.agentInfoGroup.Controls.Add(this.label5);
            this.agentInfoGroup.Controls.Add(this.label1);
            this.agentInfoGroup.Controls.Add(this.productNameLbl);
            this.agentInfoGroup.Location = new System.Drawing.Point(12, 12);
            this.agentInfoGroup.Name = "agentInfoGroup";
            this.agentInfoGroup.Size = new System.Drawing.Size(795, 86);
            this.agentInfoGroup.TabIndex = 3;
            this.agentInfoGroup.TabStop = false;
            this.agentInfoGroup.Text = "Agent information";
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Location = new System.Drawing.Point(6, 49);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(86, 17);
            this.productNameLbl.TabIndex = 0;
            this.productNameLbl.Text = "Agent Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.editBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // AddAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.agentInfoGroup);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddAgentForm";
            this.Text = "AddAgentForm";
            this.Load += new System.EventHandler(this.AddAgentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentGrd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.agentInfoGroup.ResumeLayout(false);
            this.agentInfoGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView agentGrd;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox agentAddressTxt;
        private System.Windows.Forms.TextBox agentNameTxt;
        private System.Windows.Forms.TextBox agentIdTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox agentInfoGroup;
        private System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}