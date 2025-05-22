using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Contact_Manager
{
    public partial class frmContacts : Form
    {
        public frmContacts()
        {
            InitializeComponent();
        }
        string name;
        string phone;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            phone = txtPhone.Text;

            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                if (phone.All(char.IsDigit))
                {
                    if (phone.Length >= 10 && phone.Length <= 13)
                    {
                        // Bug: Doesn't check if fields are empty
                        // Bug: Accepts invalid phone number
                        lstDisplay.Items.Add(name + " - " + phone);
                        txtName.Clear();
                        txtPhone.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Length should be below 11.");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Phone number should in digit.");
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Fields can't be empty.");
                Clear();
            }
        }

        private void frmContacts_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDisplay.SelectedItem != null)
            {
                lstDisplay.Items.Remove(lstDisplay.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a contact in a list box.");
                Clear();
            }
        }

        private void Clear()
        {
            txtName.Clear();
            txtPhone.Clear();
        }

    }
}
