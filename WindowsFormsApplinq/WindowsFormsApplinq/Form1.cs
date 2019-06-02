﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Sdk;
using Microsoft.SqlServer.Management.SmoMetadataProvider;
using Microsoft.SqlServer.Dts.Tasks;
using Microsoft.SqlServer.Management.IntegrationServices;
using System.Data.SqlClient;
using Microsoft.SqlServer;


namespace WindowsFormsApplinq
{
    public partial class Form1 : Form
    {
        public DataClasses1DataContext DC1 = new DataClasses1DataContext();

        public Form1()
        {
            InitializeComponent();
            formload();
        }

        private void formload()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Bills = from b in db.MonthlyBills
                            //where b.BILL == "Dance"
                        select b;
            dgMonthly.DataSource = db.MonthlyBills;

            DataClasses2DataContext key = new DataClasses2DataContext();
            //var keybalance = from k in key.KeyBalances
            //                     //where b.bill == "dance"
            //                 select k;
            DatagridKeyBalance.DataSource = key.KeyBalances;
            DatagridKeyBalance.Columns[2].Visible = false;

            DataClasses1DataContext week = new DataClasses1DataContext();
            var weekly = from w in week.WeeklyBills
                             //where b.BILL == "Dance"
                         select w;
            DataGridWeeklyBIlls.DataSource = week.WeeklyBills;

            DataClasses1DataContext bringHome = new DataClasses1DataContext();
            var bh = from br in bringHome.BringHomePays
                             //where b.BILL == "Dance"
                         select br;
            dgBringHome.DataSource = bringHome.BringHomePays;
        }
        public void DataGridview1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //DataClasses1DataContext db = new DataClasses1DataContext();
            //MonthlyBill Abill = new MonthlyBill();
            //MessageBox.Show(e.ColumnIndex.ToString());
            var editedCell = this.dgMonthly.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var newValue = editedCell.Value;
            var TheIndex = this.dgMonthly.Rows[e.RowIndex].Cells[0].Value;          
            var updateTime = from b in DC1.MonthlyBills
                         where b.BILL == TheIndex.ToString()
                         select b;
            foreach (var rowz in updateTime)

            {
                if (e.ColumnIndex.ToString() == "1")
                {
                    rowz.COST = (float.Parse(editedCell.Value.ToString()));
                    //MessageBox.Show("Cost");
                }
                else if(e.ColumnIndex.ToString() == "2")
                {
                    rowz.Date = (editedCell.Value.ToString());
                }
        
                //DC1.SubmitChanges();
            }

        }
        public void dgBringHomeValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataClasses1DataContext bh = new DataClasses1DataContext();
            //MonthlyBill Abill = new MonthlyBill();
            //MessageBox.Show(e.ColumnIndex.ToString());
            if (e.RowIndex < 0)
            {
                return;
            }


            var editedCell = this.dgBringHome.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var newValue = editedCell.Value;
            var TheIndex = this.dgBringHome.Rows[e.RowIndex].Cells[0].Value;
            var updateBringHome = from b in DC1.BringHomePays
                                  where b.Name == TheIndex.ToString()
                                  select b;
            foreach (var rowzies in updateBringHome)

            {
                if (e.ColumnIndex.ToString() == "0")
                {
                    rowzies.Name = (editedCell.Value.ToString());
                    //MessageBox.Show("Cost");
                }
                else if (e.ColumnIndex.ToString() == "1")
                {
                    rowzies.Amount = (int.Parse(editedCell.Value.ToString()));
                }
            }

        }

            private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataClasses1DataContext db = new DataClasses1DataContext();
            //MonthlyBill Abill = new MonthlyBill();
            //var d = db.GetChangeSet();
            //MessageBox.Show(d.ToString());
            //db.SubmitChanges();
        }

        public void BtnSubmit_Click(object sender, EventArgs e)
        {
            DC1.SubmitChanges();

            string TheBill = "";
            DataClasses1DataContext DC = new DataClasses1DataContext();
            MonthlyBill Abill = new MonthlyBill();
            int rowindex = dgMonthly.CurrentRow.Index;
            TheBill = dgMonthly.Rows[rowindex].Cells[0].Value.ToString();

            var update = from b in DC.MonthlyBills
                         where b.BILL == TheBill
                         select b;

            foreach (var row in update)

            {
                row.BILL = Convert.ToString(dgMonthly.Rows[rowindex].Cells[0].Value);
                row.COST = Convert.ToSingle(dgMonthly.Rows[rowindex].Cells[1].Value);
                row.Date = Convert.ToString(dgMonthly.Rows[rowindex].Cells[2].Value);
                DC.SubmitChanges();
            }


            float KeyBalanceUpdate;
            DataClasses2DataContext KY = new DataClasses2DataContext();
            KeyBalance KeyB = new KeyBalance();
            int rowindexKey = DatagridKeyBalance.CurrentRow.Index;

            KeyBalanceUpdate = float.Parse(DatagridKeyBalance.Rows[0].Cells[0].Value.ToString());
            KeyBalance BB = KY.KeyBalances
            .Where(c => c.Placeholder == "X")
            .Single();

            BB.KeyBalance1 = KeyBalanceUpdate;
            BB.DateTime = DateTime.Now;
            //KY.BankBalance2s.Attach(BB);
            KY.SubmitChanges();


            string WE = "";
            float amount;
            DataClasses1DataContext w = new DataClasses1DataContext();
            WeeklyBill we = new WeeklyBill();
            int windex = DataGridWeeklyBIlls.CurrentRow.Index;

            WE = DataGridWeeklyBIlls.Rows[windex].Cells[0].Value.ToString();
            amount = float.Parse(DataGridWeeklyBIlls.Rows[windex].Cells[1].Value.ToString());
            WeeklyBill wb = w.WeeklyBills
            .Where(c => c.Bill == WE)
            .Single();
            wb.Cost = amount;
            w.SubmitChanges();

            float bh;
            string thename;
            DataClasses1DataContext Bringit = new DataClasses1DataContext();
            BringHomePay BRHOME = new BringHomePay();
            int bindex = dgBringHome.CurrentRow.Index;

            thename = dgBringHome.Rows[bindex].Cells[0].Value.ToString();
            bh = float.Parse(dgBringHome.Rows[bindex].Cells[1].Value.ToString());
            BringHomePay brh = Bringit.BringHomePays
            .Where(c => c.Name == thename)
            .Single();
            brh.Amount = bh;
            Bringit.SubmitChanges();


            //string TheBill = "";
            //DataClasses1DataContext DC = new DataClasses1DataContext();
            //MonthlyBill Abill = new MonthlyBill();
            //int rowindex = dgMonthly.CurrentRow.Index;
            //TheBill = dgMonthly.Rows[rowindex].Cells[0].Value.ToString();

            //var update = from b in DC.MonthlyBills
            //             where b.BILL == TheBill
            //             select b;

            //Abill.BILL = Convert.ToString(dgMonthly.Rows[rowindex].Cells[0].Value);
            //Abill.COST = Convert.ToSingle(dgMonthly.Rows[rowindex].Cells[1].Value);
            //Abill.Date = Convert.ToString(dgMonthly.Rows[rowindex].Cells[2].Value);
            //DC.SubmitChanges(); 


            //DC.MonthlyBills.InsertOnSubmit(Abill);
            //DC.MonthlyBills.
            //DC.SubmitChanges();
            //MessageBox.Show("Saved");
            //rowindex = 0;
            //Refresh();            
        }




        private void BtDelete_Click(object sender, EventArgs e)
        {


            string TheBill = "";
            DataClasses1DataContext DC = new DataClasses1DataContext();
            MonthlyBill Abill = new MonthlyBill();
            int rowindex = dgMonthly.CurrentRow.Index;
            TheBill = dgMonthly.Rows[rowindex].Cells[0].Value.ToString();

            var delete = from b in DC.MonthlyBills
                         where b.BILL == TheBill
                         select b;

            DC.MonthlyBills.DeleteAllOnSubmit(delete);
            DC.SubmitChanges();

            rowindex = 0;
            MessageBox.Show("deleted");
            Refresh();

            
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridWeeklyBIlls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billsDataSet.BringHomePay' table. You can move, or remove it, as needed.
            this.bringHomePayTableAdapter.Fill(this.billsDataSet.BringHomePay);

        }
    }
}
