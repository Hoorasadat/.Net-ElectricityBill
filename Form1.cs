using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        List<Customer> customerList;
        Customer currentCustomer;

        public Form1()
        {
            InitializeComponent();
            customerList = new List<Customer>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void crtBtn_Click_1(object sender, EventArgs e)
        {
            string accountNo = txtbAccNo.Text;
            string fName = txtbFstNm.Text;
            string lName = txtbLstNm.Text;
            decimal powerUsg = Math.Round(Convert.ToDecimal(txtbPwrUsg.Text), 2);

            txtbPwrUsg.Text = powerUsg.ToString();

            if (accountNo == "")
                currentCustomer = new Customer(fName, lName, powerUsg);
            else
            {
                int accNo = Convert.ToInt32(accountNo);
                currentCustomer = new Customer(accNo, fName, lName, powerUsg);
            }

            MessageBox.Show(currentCustomer.ToString());
        
            customerList.Add(currentCustomer);
            lstBxCstm.Items.Add(currentCustomer.CreateCustomer());
            updateStatistics();
            txtbAccNo.Focus();
            ResetFields();
        }

        private void txtbPwrUsg_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txtbPwrUsg.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtbPwrUsg.Text = txtbPwrUsg.Text.Remove(txtbPwrUsg.Text.Length - 1);
            }
        }

        private void updateStatistics()
        {
            int noOfCustomers = customerList.Count;
            txtbNoCstm.Text = noOfCustomers.ToString();

            decimal totalUsage = 0;
            decimal totalBillAmount = 0; 
            for(int i = 0; i < customerList.Count; i++)
            {
                totalUsage += customerList[i].PowerUsage;
                totalBillAmount += customerList[i].BillAmount;
            }

            txtbTtlUsg.Text = totalUsage.ToString("C");
            if (customerList.Count > 0)
                txtbAvgBill.Text = (totalBillAmount / noOfCustomers).ToString("C");
            else
                txtbAvgBill.Text = 0.ToString();

        }

        private void txtbAccNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbAccNo.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtbAccNo.Text = txtbAccNo.Text.Remove(txtbAccNo.Text.Length - 1);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int index = lstBxCstm.SelectedIndex;
                lstBxCstm.Items.RemoveAt(index);
                customerList.RemoveAt(index);
                updateStatistics();
            }

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            txtbAccNo.Text = "";
            txtbFstNm.Text = "";
            txtbLstNm.Text = "";
            txtbPwrUsg.Text = "";
        }
    }
}
