namespace Pizza_Ordering_System
{
    partial class frmCustDtl
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.btnCustAdd = new System.Windows.Forms.Button();
            this.btnCustClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustSin = new System.Windows.Forms.TextBox();
            this.daGridCustDtl = new System.Windows.Forms.DataGridView();
            this.custIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizza_Ordering_SystemDataSet1 = new Pizza_Ordering_System.Pizza_Ordering_SystemDataSet1();
            this.tbCustomerTableAdapter = new Pizza_Ordering_System.Pizza_Ordering_SystemDataSet1TableAdapters.tbCustomerTableAdapter();
            this.btnCustPrev = new System.Windows.Forms.Button();
            this.btnCustNext = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troppingDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.daGridCustDtl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_Ordering_SystemDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informações do Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone:";
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(98, 68);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(75, 20);
            this.txtCustId.TabIndex = 0;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(98, 100);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(235, 20);
            this.txtCustName.TabIndex = 1;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(98, 126);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(235, 20);
            this.txtCustAddress.TabIndex = 2;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(98, 163);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(174, 20);
            this.txtCustPhone.TabIndex = 3;
            // 
            // btnCustAdd
            // 
            this.btnCustAdd.Location = new System.Drawing.Point(167, 367);
            this.btnCustAdd.Name = "btnCustAdd";
            this.btnCustAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCustAdd.TabIndex = 4;
            this.btnCustAdd.Text = "ADD";
            this.btnCustAdd.UseVisualStyleBackColor = true;
            this.btnCustAdd.Click += new System.EventHandler(this.btnCustAdd_Click);
            // 
            // btnCustClose
            // 
            this.btnCustClose.Location = new System.Drawing.Point(98, 396);
            this.btnCustClose.Name = "btnCustClose";
            this.btnCustClose.Size = new System.Drawing.Size(200, 23);
            this.btnCustClose.TabIndex = 6;
            this.btnCustClose.Text = "DETALHE DO CLIENTE";
            this.btnCustClose.UseVisualStyleBackColor = true;
            this.btnCustClose.Click += new System.EventHandler(this.btnCustClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "SIN:";
            // 
            // txtCustSin
            // 
            this.txtCustSin.Enabled = false;
            this.txtCustSin.Location = new System.Drawing.Point(220, 68);
            this.txtCustSin.Name = "txtCustSin";
            this.txtCustSin.Size = new System.Drawing.Size(52, 20);
            this.txtCustSin.TabIndex = 8;
            // 
            // daGridCustDtl
            // 
            this.daGridCustDtl.AutoGenerateColumns = false;
            this.daGridCustDtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daGridCustDtl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIdDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.custAddressDataGridViewTextBoxColumn,
            this.custPhoneDataGridViewTextBoxColumn});
            this.daGridCustDtl.DataSource = this.tbCustomerBindingSource;
            this.daGridCustDtl.Location = new System.Drawing.Point(63, 211);
            this.daGridCustDtl.Name = "daGridCustDtl";
            this.daGridCustDtl.Size = new System.Drawing.Size(270, 150);
            this.daGridCustDtl.TabIndex = 9;
            this.daGridCustDtl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.daGridCustDtl_CellContentClick);
            // 
            // custIdDataGridViewTextBoxColumn
            // 
            this.custIdDataGridViewTextBoxColumn.DataPropertyName = "custId";
            this.custIdDataGridViewTextBoxColumn.HeaderText = "custId";
            this.custIdDataGridViewTextBoxColumn.Name = "custIdDataGridViewTextBoxColumn";
            this.custIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "custName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "custName";
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            // 
            // custAddressDataGridViewTextBoxColumn
            // 
            this.custAddressDataGridViewTextBoxColumn.DataPropertyName = "custAddress";
            this.custAddressDataGridViewTextBoxColumn.HeaderText = "custAddress";
            this.custAddressDataGridViewTextBoxColumn.Name = "custAddressDataGridViewTextBoxColumn";
            // 
            // custPhoneDataGridViewTextBoxColumn
            // 
            this.custPhoneDataGridViewTextBoxColumn.DataPropertyName = "custPhone";
            this.custPhoneDataGridViewTextBoxColumn.HeaderText = "custPhone";
            this.custPhoneDataGridViewTextBoxColumn.Name = "custPhoneDataGridViewTextBoxColumn";
            // 
            // tbCustomerBindingSource
            // 
            this.tbCustomerBindingSource.DataMember = "tbCustomer";
            this.tbCustomerBindingSource.DataSource = this.pizza_Ordering_SystemDataSet1;
            // 
            // pizza_Ordering_SystemDataSet1
            // 
            this.pizza_Ordering_SystemDataSet1.DataSetName = "Pizza_Ordering_SystemDataSet1";
            this.pizza_Ordering_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCustomerTableAdapter
            // 
            this.tbCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // btnCustPrev
            // 
            this.btnCustPrev.Location = new System.Drawing.Point(63, 367);
            this.btnCustPrev.Name = "btnCustPrev";
            this.btnCustPrev.Size = new System.Drawing.Size(75, 23);
            this.btnCustPrev.TabIndex = 10;
            this.btnCustPrev.Text = "ANTERIOR";
            this.btnCustPrev.UseVisualStyleBackColor = true;
            this.btnCustPrev.Click += new System.EventHandler(this.btnCustPrev_Click);
            // 
            // btnCustNext
            // 
            this.btnCustNext.Location = new System.Drawing.Point(258, 367);
            this.btnCustNext.Name = "btnCustNext";
            this.btnCustNext.Size = new System.Drawing.Size(75, 23);
            this.btnCustNext.TabIndex = 11;
            this.btnCustNext.Text = "PRÓXIMO";
            this.btnCustNext.UseVisualStyleBackColor = true;
            this.btnCustNext.Click += new System.EventHandler(this.btnCustNext_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderDetailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderDetailToolStripMenuItem
            // 
            this.orderDetailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.troppingDetailToolStripMenuItem});
            this.orderDetailToolStripMenuItem.Name = "orderDetailToolStripMenuItem";
            this.orderDetailToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.orderDetailToolStripMenuItem.Text = "Encomenda";
            this.orderDetailToolStripMenuItem.Click += new System.EventHandler(this.orderDetailToolStripMenuItem_Click);
            // 
            // troppingDetailToolStripMenuItem
            // 
            this.troppingDetailToolStripMenuItem.Name = "troppingDetailToolStripMenuItem";
            this.troppingDetailToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.troppingDetailToolStripMenuItem.Text = "Detalhe agrupamento";
            // 
            // frmCustDtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(371, 421);
            this.Controls.Add(this.btnCustNext);
            this.Controls.Add(this.btnCustPrev);
            this.Controls.Add(this.daGridCustDtl);
            this.Controls.Add(this.txtCustSin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCustClose);
            this.Controls.Add(this.btnCustAdd);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCustDtl";
            this.Text = "Detalhe ao Cliente";
            this.Load += new System.EventHandler(this.frmCustDtl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daGridCustDtl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_Ordering_SystemDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.Button btnCustAdd;
        private System.Windows.Forms.Button btnCustClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustSin;
        private System.Windows.Forms.DataGridView daGridCustDtl;
        private Pizza_Ordering_SystemDataSet1 pizza_Ordering_SystemDataSet1;
        private System.Windows.Forms.BindingSource tbCustomerBindingSource;
        private Pizza_Ordering_SystemDataSet1TableAdapters.tbCustomerTableAdapter tbCustomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCustPrev;
        private System.Windows.Forms.Button btnCustNext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troppingDetailToolStripMenuItem;
    }
}