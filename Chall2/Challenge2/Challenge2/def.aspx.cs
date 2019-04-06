using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge2
{
    public partial class def : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void FirstNum_TextChanged(object sender, EventArgs e)
        {
            int firstd = int.Parse(firstNum.Text);
        }

        public void SecText_TextChanged(object sender, EventArgs e)
        {
            int secondd = int.Parse(secText.Text);
        }

        protected void add_Click(object sender, EventArgs e)
        {
            int firstd = int.Parse(firstNum.Text);
            int secondd = int.Parse(secText.Text);

            int result = firstd + secondd;
            resultLabel.Text = result.ToString();

        }

        protected void subtract_Click(object sender, EventArgs e)
        {
            int firstd = int.Parse(firstNum.Text);
            int secondd = int.Parse(secText.Text);

            int result = firstd - secondd;
            resultLabel.Text = result.ToString();

        }

        protected void multiply_Click(object sender, EventArgs e)
        {
            int firstd = int.Parse(firstNum.Text);
            int secondd = int.Parse(secText.Text);

            double result = firstd * secondd;
            resultLabel.Text = result.ToString();

        }

        protected void divide_Click(object sender, EventArgs e)
        {
            firstNum.Text = "";
            double firstd = double.Parse(firstNum.Text);
            double secondd = double.Parse(secText.Text);

            double result = firstd / secondd;
            resultLabel.Text = result.ToString();
        }
    }
}