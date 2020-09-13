using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class tipCalculatorWindow : Form
    {
        //Variable declaration.
        public String bill, tip, total;
        public Boolean totalError;


        public tipCalculatorWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            totalError = false;

            //Assigns variables
            setBill(txtBill.Text);
            setTip(txtTip.Text);

            //Calls the calcTotal method to run the calculation for the total
            calcTotal(getBill(), getTip());

            //Returns the result to the text field of txtTotal if no errors are found
            if(totalError==false)
            {
                txtTotal.Text = getTotal();
            }
            else
            {
                txtTotal.Text = "Error";
            }
            
        }

        public String getBill()
        {
            return bill;
        }

        public void setBill(String bill)
        {
            this.bill = bill;
        }

        public String getTip()
        {
            return tip;
        }

        public void setTip(String tip)
        {
            this.tip = tip;
        }

        public String getTotal()
        {
            return total;
        }

        public void setTotal(String total)
        {
            this.total = total;
        }

        public void calcTotal(String bill, String tip)
        {
            //Convert variables
            Double billDouble = 0;
            Double tipDouble = 0;

            //Attempt to convert varable "bill" from string to double if user input is valid
            try
            {
                billDouble = Convert.ToDouble(bill);
                totalError = false;
                try
                {
                    tipDouble = Convert.ToDouble(tip) / 100;

                    //Calculates the total based on the bill and tip percentage and then rounds this value up to the last two decimals
                    Double total = Math.Round(((billDouble * tipDouble) + billDouble), 2, MidpointRounding.ToEven);

                    setTotal(total.ToString());
                    errorMessage.Text = "";
                }
                catch (Exception e)
                {
                    if(totalError == false)
                    {
                        errorMessage.Text = "Error Found: please enter a 1valid number for the tip.";
                        totalError = true;
                    }
                    else
                    {
                        errorMessage.Text = "Error Found: please enter a valid number for the bill and tip.";
                    }
                    
                }
            }
            catch(Exception e)
            {
                errorMessage.Text = "Error Found: please enter a valid number for the bill.";
                totalError = true;
            }
        }
    }
}
