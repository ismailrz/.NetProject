using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class BookShopForm : Form
    {
        public BookShopForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            displayRichTextBox.Text = "Name: " + nameTextBox.Text + "\n\n" + "Contact Number: " 
                + contactTextBox.Text + "\n\n" + "Address: " + addressTextBox.Text + "\n\nOrder: " 
                + orderComboBox.Text + "\n\nQuantity: " + quantityTextBox.Text;
        }
    }
}
