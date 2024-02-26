using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Buffet_Sales_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cashBoxAmount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, water, tea, ticket ,total;
            popcorn = Convert.ToInt32(TxtPopcorn.Text);
            water = Convert.ToInt32(TxtWater.Text);
            tea = Convert.ToInt32(TxtTea.Text);
            ticket = Convert.ToInt32(TxtTicket.Text);

            total=popcorn*10+water*5+tea*20+ticket*30;

            LblTotal.Text = total.ToString();

            cashBoxAmount = cashBoxAmount + total;
            LblCashBox.Text = cashBoxAmount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtPopcorn.Text = " ";
            TxtWater.Text = "";
            TxtTea.Text = "";
            TxtTicket.Text = "";
            TxtPopcorn.Focus();
            
        }
    }
}
