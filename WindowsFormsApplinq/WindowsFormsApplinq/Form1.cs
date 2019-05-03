using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Bills = from b in db.MonthlyBills
                        //where b.BILL == "Dance"
                        select b;
            DataGrid.DataSource = db.MonthlyBills;

            DataClasses1DataContext key = new DataClasses1DataContext();
            var keybalance = from k in key.KeyBalances
                            //where b.BILL == "Dance"
                        select k;
            DatagridKeyBalance.DataSource = key.KeyBalances;

            DataClasses1DataContext week = new DataClasses1DataContext();
            var weekly = from w in week.WeeklyBills
                                 //where b.BILL == "Dance"
                             select w;
            DataGridWeeklyBIlls.DataSource = week.WeeklyBills;

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            MonthlyBill Abill = new MonthlyBill();
            var d = db.GetChangeSet();
            MessageBox.Show(d.ToString());
            db.SubmitChanges();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

                string TheBill = "";
                DataClasses1DataContext DC = new DataClasses1DataContext();
                MonthlyBill Abill = new MonthlyBill(); 
                int rowindex = DataGrid.CurrentRow.Index; 
                TheBill = DataGrid.Rows[rowindex].Cells[0].Value.ToString();

                var update = from b in DC.MonthlyBills
                             where b.BILL == TheBill
                             select b;

                foreach (var row in update)

                {
                    row.BILL = Convert.ToString(DataGrid.Rows[rowindex].Cells[0].Value);
                    row.COST = Convert.ToSingle(DataGrid.Rows[rowindex].Cells[1].Value);
                    row.Date = Convert.ToString(DataGrid.Rows[rowindex].Cells[2].Value);
                    DC.SubmitChanges(); 
                }

                var changeset = DC.GetChangeSet();

                int KeyBalanceUpdate;
                DataClasses1DataContext KY = new DataClasses1DataContext();
                KeyBalance KeyB = new KeyBalance();
                int rowindexKey = DatagridKeyBalance.CurrentRow.Index;
                KeyBalanceUpdate = DatagridKeyBalance.Rows[rowindex].Cells[0].Value;

                var updatekey = from k in KY.KeyBalances
                                where k.KeyBalance1 == KeyBalanceUpdate
                                select k;

                foreach (var row in updatekey)

                {
                    row.KeyBalance1 = Convert.ToString(DatagridKeyBalance.Rows[rowindex].Cells[0].Value);
                    //row.Date = 
                    //Convert.ToSingle(DataGrid.Rows[rowindex].Cells[1].Value);
                    //row.Date = Convert.ToString(DataGrid.Rows[rowindex].Cells[2].Value);
                    DC.SubmitChanges();
                }
            MessageBox.Show("Updated");
                Refresh();

            
        }

        private void BtInsert_Click(object sender, EventArgs e)
        {


            string TheBill = "";
            DataClasses1DataContext DC = new DataClasses1DataContext();
            MonthlyBill Abill = new MonthlyBill();
            int rowindex = DataGrid.CurrentRow.Index;
            TheBill = DataGrid.Rows[rowindex].Cells[0].Value.ToString();

            var update = from b in DC.MonthlyBills
                         where b.BILL == TheBill
                         select b;

            Abill.BILL = Convert.ToString(DataGrid.Rows[rowindex].Cells[0].Value);
            Abill.COST = Convert.ToSingle(DataGrid.Rows[rowindex].Cells[1].Value);
            Abill.Date = Convert.ToString(DataGrid.Rows[rowindex].Cells[2].Value);
            DC.SubmitChanges(); 


            DC.MonthlyBills.InsertOnSubmit(Abill);
            DC.SubmitChanges();
            MessageBox.Show("Saved");
            rowindex = 0;
            Refresh();            
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {


            string TheBill = "";
            DataClasses1DataContext DC = new DataClasses1DataContext();
            MonthlyBill Abill = new MonthlyBill();
            int rowindex = DataGrid.CurrentRow.Index;
            TheBill = DataGrid.Rows[rowindex].Cells[0].Value.ToString();

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
    }
}
