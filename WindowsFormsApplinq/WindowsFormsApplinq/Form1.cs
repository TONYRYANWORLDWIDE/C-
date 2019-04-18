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
            //DataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Bills = from b in db.MonthlyBills
                        //where b.BILL == "Dance"
                        select b;

            //DataGrid.DataSource = Bills.ToList();
            DataGrid.DataSource = db.MonthlyBills;
            



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
                    DC.SubmitChanges(); // here will submitchanges function call and queries will automatic call.
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
            DC.SubmitChanges(); // here will submitchanges function call and queries will automatic call.


            DC.MonthlyBills.InsertOnSubmit(Abill);//InsertOnSubmit queries will automatic call thats the data context class handle it.

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

            DC.MonthlyBills.DeleteAllOnSubmit(delete);// DeleteAllOnSubmit function will call and queries will automatic call thats the data context class handle it.

            DC.SubmitChanges();

            // SI = SDCD1.StudentInfos.Single(c => c.Id == iid);

            rowindex = 0;

            MessageBox.Show("deleted");

            Refresh();

            
        }
    }
}
