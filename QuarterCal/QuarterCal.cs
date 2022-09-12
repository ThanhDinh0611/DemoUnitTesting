using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarterCal
{
    public partial class QuarterCal : Form
    {
        public QuarterCal()
        {
            InitializeComponent();
        }

        public string CalculateQuarter(int month)
        {
            // Evaluating the month
            if (month <= 0)
            {
                return "Tháng không hợp lệ!";
            }
            else if (month <= 3)
            {
                return "Quý 1";
            }
            else if (month <= 6)
            {
                return "Quý 2";
            }
            else if (month <= 9)
            {
                return "Quý 3";
            }
            else if (month <= 12)
            {
                return "Quý 4";
            }
            else
            {
                return "Tháng không hợp lệ!";
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            //Get month
            try
            {
                int Month = Convert.ToInt32(txtMonth.Text);

                //Processing and returning result
                lblResult.Text = CalculateQuarter(Month);
            }
            catch
            {
                lblResult.Text = "Tháng không hợp lệ!";
                return;
            }
        }
    }
}
