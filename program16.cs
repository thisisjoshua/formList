/*
 * Project:         Program 16
 * Date:            December 2018
 * Developed By:    Josh Craven
 * Class Name:      program16
 * Purpose:         Create program to add charters and calculate fees
 * Uses:            Charter and CharterManager
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; // additional namespace


namespace jcravenAS7
{
    public partial class program16 : Form
    {
        public program16()
        {
            InitializeComponent();
        }
        // declare a class/module level variable of type CharterManager
        private CharterManager aCharterManager;


        private void btnAddCharter_Click(object sender, EventArgs e)
        {
            // declare local (i.e., method-level) variables

            string customerName, yachtType;
            int yachtSize;
            decimal charterHours;

            Charter aCharter;

            //errors for missing inputs
            if (txtCustomer.Text == string.Empty)
            {
                MessageBox.Show("Enter a customer please!", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboYT.Text == string.Empty)
            {
                MessageBox.Show("Enter a yacht please!", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboYS.Text == string.Empty)
            {
                MessageBox.Show("Enter a yacht size please!", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudCH.Value < 0)
            {
               MessageBox.Show("Enter charter hours please!", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // assign input to variables

            customerName = txtCustomer.Text;
            yachtType = cboYT.Text;
            yachtSize = Convert.ToInt32(cboYS.Text);
            charterHours = Convert.ToDecimal(nudCH.Value);

            //instatiate a charter object
            aCharter = new Charter(customerName, yachtType, yachtSize, charterHours);

            //instatiate aCharterManager
            if (aCharterManager is null)
            {
                aCharterManager = new CharterManager();
            }

            //call addcharter method
            aCharterManager.AddCharter(aCharter);

            //enable menu tools
            allChartersToolStripMenuItem.Enabled = true;
            numberOfChartersToolStripMenuItem.Enabled = true;
            chartersSummaryToolStripMenuItem.Enabled = true;

            //disable object inputs
            txtCustomer.Enabled = false;
            cboYT.Enabled = false;
            cboYS.Enabled = false;
            nudCH.Enabled = false;

        }

        private void addYachtTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboYT.Text == string.Empty)
            {
                MessageBox.Show("Enter a new yacht", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newMember = cboYT.Text;  //assign the new member to be added to a variable
            bool duplicate = false;  // duplication indicator 

            //a foreach loop to iterate through the items in the list and check for potential duplication

            foreach (string aItem in cboYT.Items) //for each item in the combo box
            {
                if (string.Equals(newMember, aItem, StringComparison.OrdinalIgnoreCase)) //ignoring case, compare each member in the list to the member to be added
                {
                    duplicate = true; //if the member already exists in the list, set duplication indicator to true
                    break; //break out of the loop
                }
            }

            if (duplicate)  //if duplicate is true, new member is not added
            {
                MessageBox.Show("Yacht not added", "Duplicate member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboYT.Text = string.Empty;
            }
            else  //otherwise, new member is added
            {
                TextInfo aTextInfo = new CultureInfo("en-US", false).TextInfo; //create a TextInfo object based on "en-US" culture

                newMember = aTextInfo.ToTitleCase(newMember); //change the name of the new member to be added to proper case

                cboYT.Items.Add(newMember); //add the new member to the list
                MessageBox.Show("New yacht added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboYT.Text = string.Empty;
            }
        }

        private void removeYachtTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboYT.SelectedIndex == -1)
            {
                MessageBox.Show("Select the yacht to remove", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cboYT.Items.RemoveAt(cboYT.SelectedIndex); //remove selected member from list
                MessageBox.Show("Yacht removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboYT.Text = string.Empty;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void allChartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display yacht objects in list collection in new form
            CharterList aForm = new CharterList();
            aForm.charterManagerBindingSource.DataSource = aCharterManager;
            aForm.ShowDialog();
        }

        private void resetForNextCharterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reset form
            txtCustomer.Clear();
            cboYT.SelectedIndex = -1;
            cboYS.SelectedIndex = -1;
            nudCH.Value = 0;

            //enable controls
            txtCustomer.Enabled = true;
            cboYT.Enabled = true;
            cboYS.Enabled = true;
            nudCH.Enabled = true;

            //set focus

            txtCustomer.Focus();
        }

        private void numberOfChartersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string result = (string)cboYS.SelectedValue;

            string count = aCharterManager.GetCharterCount().ToString();

            MessageBox.Show($"There is/are {count} charters for {result} feet yachts.", "Number of Charter for Selected Charter Size", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartersSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartersSummary aForm = new ChartersSummary();
            
            aForm.lblLowest.Text = aCharterManager.FindLowestCharterFee().ToString("c2");

            aForm.lblTotal.Text = aCharterManager.GetTotalCharterFees().ToString("c2");

            aForm.lblAverage.Text = aCharterManager.GetAverageCharterFee().ToString("c2");

            aForm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (cboYT.Text == string.Empty)
            {
                MessageBox.Show("Enter a new yacht", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newMember = cboYT.Text;  //assign the new member to be added to a variable
            bool duplicate = false;  // duplication indicator 

            //a foreach loop to iterate through the items in the list and check for potential duplication

            foreach (string aItem in cboYT.Items) //for each item in the combo box
            {
                if (string.Equals(newMember, aItem, StringComparison.OrdinalIgnoreCase)) //ignoring case, compare each member in the list to the member to be added
                {
                    duplicate = true; //if the member already exists in the list, set duplication indicator to true
                    break; //break out of the loop
                }
            }

            if (duplicate)  //if duplicate is true, new member is not added
            {
                MessageBox.Show("Yacht not added", "Duplicate member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboYT.Text = string.Empty;
            }
            else  //otherwise, new member is added
            {
                TextInfo aTextInfo = new CultureInfo("en-US", false).TextInfo; //create a TextInfo object based on "en-US" culture

                newMember = aTextInfo.ToTitleCase(newMember); //change the name of the new member to be added to proper case

                cboYT.Items.Add(newMember); //add the new member to the list
                MessageBox.Show("New yacht added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboYT.Text = string.Empty;
            }
        }

        private void removeYachtTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cboYT.SelectedIndex == -1)
            {
                MessageBox.Show("Select the yacht to remove", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cboYT.Items.RemoveAt(cboYT.SelectedIndex); //remove selected member from list
                MessageBox.Show("Yacht removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboYT.Text = string.Empty;
            }
        }
    }
    
    
    
}
