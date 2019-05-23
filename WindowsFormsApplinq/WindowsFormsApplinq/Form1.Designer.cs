namespace WindowsFormsApplinq
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgMonthly = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.DatagridKeyBalance = new System.Windows.Forms.DataGridView();
            this.DataGridWeeklyBIlls = new System.Windows.Forms.DataGridView();
            this.bringHomePayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsDataSet = new WindowsFormsApplinq.BillsDataSet();
            this.bringHomePayTableAdapter = new WindowsFormsApplinq.BillsDataSetTableAdapters.BringHomePayTableAdapter();
            this.dgBringHome = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgMonthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridKeyBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWeeklyBIlls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bringHomePayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBringHome)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMonthly
            // 
            this.dgMonthly.AllowUserToOrderColumns = true;
            this.dgMonthly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMonthly.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMonthly.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMonthly.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgMonthly.Location = new System.Drawing.Point(61, 33);
            this.dgMonthly.Name = "dgMonthly";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMonthly.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgMonthly.Size = new System.Drawing.Size(350, 566);
            this.dgMonthly.TabIndex = 0;
            this.dgMonthly.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgMonthly.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridview1_CellValueChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(782, 622);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 45);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit Changes";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(623, 622);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(109, 45);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;

            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(476, 622);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(93, 45);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // DatagridKeyBalance
            // 
            this.DatagridKeyBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatagridKeyBalance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DatagridKeyBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridKeyBalance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DatagridKeyBalance.Location = new System.Drawing.Point(476, 33);
            this.DatagridKeyBalance.Name = "DatagridKeyBalance";
            this.DatagridKeyBalance.RowTemplate.Height = 24;
            this.DatagridKeyBalance.Size = new System.Drawing.Size(427, 84);
            this.DatagridKeyBalance.TabIndex = 4;
            this.DatagridKeyBalance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // DataGridWeeklyBIlls
            // 
            this.DataGridWeeklyBIlls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridWeeklyBIlls.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridWeeklyBIlls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridWeeklyBIlls.Location = new System.Drawing.Point(476, 424);
            this.DataGridWeeklyBIlls.Name = "DataGridWeeklyBIlls";
            this.DataGridWeeklyBIlls.RowTemplate.Height = 24;
            this.DataGridWeeklyBIlls.Size = new System.Drawing.Size(427, 175);
            this.DataGridWeeklyBIlls.TabIndex = 5;
            this.DataGridWeeklyBIlls.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridWeeklyBIlls_CellContentClick);
            // 
            // bringHomePayBindingSource
            // 
            this.bringHomePayBindingSource.DataMember = "BringHomePay";
            this.bringHomePayBindingSource.DataSource = this.billsDataSet;
            // 
            // billsDataSet
            // 
            this.billsDataSet.DataSetName = "BillsDataSet";
            this.billsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bringHomePayTableAdapter
            // 
            this.bringHomePayTableAdapter.ClearBeforeFill = true;
            // 
            // dgBringHome
            // 
            this.dgBringHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBringHome.Location = new System.Drawing.Point(476, 193);
            this.dgBringHome.Name = "dgBringHome";
            this.dgBringHome.RowTemplate.Height = 24;
            this.dgBringHome.Size = new System.Drawing.Size(427, 177);
            this.dgBringHome.TabIndex = 6;
            this.dgBringHome.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBringHomeValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 707);
            this.Controls.Add(this.dgBringHome);
            this.Controls.Add(this.DataGridWeeklyBIlls);
            this.Controls.Add(this.DatagridKeyBalance);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgMonthly);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMonthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridKeyBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWeeklyBIlls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bringHomePayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBringHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMonthly;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView DatagridKeyBalance;
        private System.Windows.Forms.DataGridView DataGridWeeklyBIlls;
        private BillsDataSet billsDataSet;
        private System.Windows.Forms.BindingSource bringHomePayBindingSource;
        private BillsDataSetTableAdapters.BringHomePayTableAdapter bringHomePayTableAdapter;
        private System.Windows.Forms.DataGridView dgBringHome;
    }
}

