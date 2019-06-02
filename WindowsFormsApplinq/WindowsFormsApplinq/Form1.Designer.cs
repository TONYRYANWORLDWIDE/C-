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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMonthly.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMonthly.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgMonthly.Location = new System.Drawing.Point(61, 33);
            this.dgMonthly.Name = "dgMonthly";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMonthly.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgMonthly.RowHeadersWidth = 51;
            this.dgMonthly.Size = new System.Drawing.Size(350, 566);
            this.dgMonthly.TabIndex = 0;
            //this.dgMonthly.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridview1_CellValueChanged);
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
            this.btInsert.Click += new System.EventHandler(this.BtInsert_Click);
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
            this.DatagridKeyBalance.RowHeadersWidth = 51;
            this.DatagridKeyBalance.RowTemplate.Height = 24;
            this.DatagridKeyBalance.Size = new System.Drawing.Size(427, 84);
            this.DatagridKeyBalance.TabIndex = 4;
           
            // 
            // DataGridWeeklyBIlls
            // 
            this.DataGridWeeklyBIlls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridWeeklyBIlls.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridWeeklyBIlls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridWeeklyBIlls.Location = new System.Drawing.Point(476, 424);
            this.DataGridWeeklyBIlls.Name = "DataGridWeeklyBIlls";
            this.DataGridWeeklyBIlls.RowHeadersWidth = 51;
            this.DataGridWeeklyBIlls.RowTemplate.Height = 24;
            this.DataGridWeeklyBIlls.Size = new System.Drawing.Size(427, 175);
            this.DataGridWeeklyBIlls.TabIndex = 5;
           
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
            this.dgBringHome.RowHeadersWidth = 51;
            this.dgBringHome.RowTemplate.Height = 24;
            this.dgBringHome.Size = new System.Drawing.Size(427, 177);
            this.dgBringHome.TabIndex = 6;
            //this.dgBringHome.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBringHomeValueChanged);
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

