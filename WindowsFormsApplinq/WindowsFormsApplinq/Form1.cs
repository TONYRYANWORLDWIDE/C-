using System;
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
        public int monthlyrows;
        public Form1()
        {
            InitializeComponent();
            formload();
            monthlyrows = this.dgMonthly.RowCount;
        }
        private void formload()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Bills = from b in db.MonthlyBills
                            //where b.BILL == "Dance"
                        select b;
            dgMonthly.DataSource = db.MonthlyBills;

            DataClasses2DataContext key = new DataClasses2DataContext();
            DatagridKeyBalance.DataSource = key.KeyBalances;
            DatagridKeyBalance.Columns[2].Visible = false;

            DataClasses1DataContext week = new DataClasses1DataContext();
            var weekly = from w in week.WeeklyBills
                         select w;
            DataGridWeeklyBIlls.DataSource = week.WeeklyBills;

            DataClasses1DataContext bringHome = new DataClasses1DataContext();
            var bh = from br in bringHome.BringHomePays                        
                         select br;
            dgBringHome.DataSource = bringHome.BringHomePays;
        }
        public void BtnSubmit_Click(object sender, EventArgs e)
        {
            string TheBill = "";
            DataClasses1DataContext DC = new DataClasses1DataContext();
            int newmonthlyrows = DC.MonthlyBills.Count() + 1;
            if (this.monthlyrows == newmonthlyrows)
            {
                MonthlyBill Abill = new MonthlyBill();
                int rowindex = dgMonthly.CurrentRow.Index;
                var update = from b in DC.MonthlyBills
                             select b;
                int monthlybillschanged = 0;
                foreach (var row in update)
                {
                    for (int rowz = 0; rowz < dgMonthly.RowCount - 1; rowz++)
                    {
                        TheBill = dgMonthly.Rows[rowz].Cells[0].Value.ToString();
                        if (TheBill == row.BILL)
                        {
                            if (row.COST != Convert.ToSingle(dgMonthly.Rows[rowz].Cells[1].Value) || row.Date != Convert.ToString(dgMonthly.Rows[rowz].Cells[2].Value))
                            {
                                row.COST = Convert.ToSingle(dgMonthly.Rows[rowz].Cells[1].Value);
                                row.Date = Convert.ToString(dgMonthly.Rows[rowz].Cells[2].Value);
                                monthlybillschanged++;
                            }
                        }
                    }
                }
                if (monthlybillschanged > 0)
                {
                    DC.SubmitChanges();
                    MessageBox.Show($"{monthlybillschanged} monthly bill(s) have been updated");
                }
            }           
            float KeyBalanceUpdate;
            DataClasses2DataContext KY = new DataClasses2DataContext();
            KeyBalance KeyB = new KeyBalance();
            int rowindexKey = DatagridKeyBalance.CurrentRow.Index;

            KeyBalanceUpdate = float.Parse(DatagridKeyBalance.Rows[0].Cells[0].Value.ToString());
            KeyBalance BB = KY.KeyBalances
            .Where(c => c.Placeholder == "X")
            .Single();

            if (BB.KeyBalance1 != KeyBalanceUpdate)
            {
                BB.DateTime = DateTime.Now;
                BB.KeyBalance1 = KeyBalanceUpdate;
                //KY.BankBalance2s.Attach(BB);
                KY.SubmitChanges();
                MessageBox.Show("Key Balance Updated");
            }
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
            if (wb.Cost != amount)
            {
                wb.Cost = amount;
                w.SubmitChanges();
                MessageBox.Show("Weekly BIlls Updated");
            }
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

            if( brh.Amount != bh)
            {
                brh.Amount = bh;
                Bringit.SubmitChanges();
                MessageBox.Show("Bring Home Amount Changed");
            }            
            formload();
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
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billsDataSet.BringHomePay' table. You can move, or remove it, as needed.
            this.bringHomePayTableAdapter.Fill(this.billsDataSet.BringHomePay);
        }
        private void BtInsert_Click(object sender, EventArgs e)
        {
            string TheBill = "";
            DataClasses1DataContext DC = new DataClasses1DataContext();
            MonthlyBill Abill = new MonthlyBill();
            int rowindex = dgMonthly.CurrentRow.Index;
            TheBill = dgMonthly.Rows[rowindex].Cells[0].Value.ToString();

            var update = from b in DC.MonthlyBills
                         where b.BILL == TheBill
                         select b;

            Abill.BILL = Convert.ToString(dgMonthly.Rows[rowindex].Cells[0].Value);
            Abill.COST = Convert.ToSingle(dgMonthly.Rows[rowindex].Cells[1].Value);
            Abill.Date = Convert.ToString(dgMonthly.Rows[rowindex].Cells[2].Value);
            DC.SubmitChanges();
            DC.MonthlyBills.InsertOnSubmit(Abill);    
            DC.SubmitChanges();
            MessageBox.Show("Saved");
            rowindex = 0;
            Refresh();
        }
    }
}
