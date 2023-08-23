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

        // ------------------------------------- Variables: -------------------------------------

        List<Customer> customerList;
        Customer currentCustomer;


        // ------------------------------- Initializing the form: -------------------------------

        public Form1()
        {
            InitializeComponent();

            customerList = new List<Customer>();

            lstView.View = View.Details;

            lstView.Columns.Add("        id        ", -2, HorizontalAlignment.Center);
            lstView.Columns.Add(" First Name ", -2, HorizontalAlignment.Center);
            lstView.Columns.Add(" Last Name ", - 2, HorizontalAlignment.Center);
            lstView.Columns.Add(" Power usage ", -2, HorizontalAlignment.Center);
            lstView.Columns.Add("Bill", -2, HorizontalAlignment.Center);

            ResetStatistics();
        }


        // ---------------------------------- Loading the form: ----------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        // ------------------------ Create and add a cutomer to the list: ------------------------

        private void addCrtBtn_Click(object sender, EventArgs e)
        {
            string accountNo = txtbAccNo.Text;
            string fName = txtbFstNm.Text;
            string lName = txtbLstNm.Text;
            string pwUsg = txtbPwrUsg.Text;

            if (fName == "" || lName == "" || pwUsg == "")
            {
                MessageBox.Show("You have to enter First Name, Last Name, and Power Usage!");
            }
            else
            {
                // --------------- Getting power usage amount and round it in the textbox: ---------------

                decimal powerUsg = Math.Round(Convert.ToDecimal(pwUsg), 2);

                txtbPwrUsg.Text = powerUsg.ToString();

                // --------------- Creating a new customer based on the filled textboxes: ---------------

                if (accountNo == "")
                    currentCustomer = new Customer(fName, lName, powerUsg);
                else
                {
                    int accNo = Convert.ToInt32(accountNo);
                    bool isIdUnique = checkUniqueness(accNo);
                    if (isIdUnique)
                        currentCustomer = new Customer(accNo, fName, lName, powerUsg);
                    else
                    {
                        MessageBox.Show("The account number you entered is already used for a customer!");
                        return;
                    }
                }

                // ----------------------- Showing the new customer in a Showbox: -----------------------

                MessageBox.Show(currentCustomer.ToString());

                // ----------------- Adding the new customer into the listbox and list: -----------------

                customerList.Add(currentCustomer);

                string[] cutomerListItem = {
                    currentCustomer.AccountNo.ToString(),
                    currentCustomer.FirstName,
                    currentCustomer.LastName,
                    currentCustomer.PowerUsage.ToString(),
                    currentCustomer.BillAmount.ToString(),
                };

                ListViewItem item = new ListViewItem(cutomerListItem);
                lstView.Items.Add(item);
                

                // --------------------- Updating statistics and reseting the form: ---------------------

                updateStatistics();
                txtbAccNo.Focus();
                ResetFields();
            }
        }


        // ------------------- Check if the provided account number is unique: -------------------

        private bool checkUniqueness(int number)
        {
            if (customerList.Find(x => x.AccountNo == number) != null)
                return false;
            else return true;
        }


        // ---------------- Check if the provided power usage is positive decimal: ----------------

        private void txtbPwrUsg_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbPwrUsg.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtbPwrUsg.Text = txtbPwrUsg.Text.Remove(txtbPwrUsg.Text.Length - 1);
            }
        }


        // ------------------------------- Update statistics method: -------------------------------

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

            txtbTtlUsg.Text = totalUsage.ToString();
            if (customerList.Count > 0)
                txtbAvgBill.Text = (totalBillAmount / noOfCustomers).ToString("C");
            else
                txtbAvgBill.Text = 0.ToString("C");
        }


        // --------------- Check if the provided account number is positive integer: ---------------

        private void txtbAccNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbAccNo.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtbAccNo.Text = txtbAccNo.Text.Remove(txtbAccNo.Text.Length - 1);
            }
        }


        // ------------------------------------- Exit the app: -------------------------------------

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // ---------------------------- Remove a customer from the list: ----------------------------

        private void removeBtn_Click(object sender, EventArgs e)
        {
            // ----------------- First check if the customer is sure about removing: -----------------

            // ------------- Creating a custom MessageBox with titile, text, and buttons: -------------

            if (MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int selectedIndex = lstView.SelectedIndices[0];
                lstView.Items.RemoveAt(selectedIndex);
                customerList.RemoveAt(selectedIndex);
                updateStatistics();
            }
        }


        // ------------------------------------- Reset button: -------------------------------------

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetFields();
        }


        // ------------------------------------- Reset method: -------------------------------------

        private void ResetFields()
        {
            txtbAccNo.Text = "";
            txtbFstNm.Text = "";
            txtbLstNm.Text = "";
            txtbPwrUsg.Text = "";
        }


        // -------------------------------- Reset Statistics method: --------------------------------

        private void ResetStatistics()
        {
            txtbNoCstm.Text = "0";
            txtbTtlUsg.Text = "0";
            txtbAvgBill.Text = 0.ToString("C");
        }

    }
}
