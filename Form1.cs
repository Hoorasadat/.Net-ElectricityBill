using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            decimal powerUsg = Convert.ToDecimal(txtbPwrUsg.Text);
            txtbPwrUsg.Text = powerUsg.ToString("N2").ToString();
            Customer customer = new Customer(txtbFstNm.Text, txtbLstNm.Text, Convert.ToDecimal(txtbPwrUsg.Text));
            MessageBox.Show(customer.ToString());

        }

        private void txtbPwrUsg_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txtbPwrUsg.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtbPwrUsg.Text = txtbPwrUsg.Text.Remove(txtbPwrUsg.Text.Length - 1);
            }
        }
    }
}
