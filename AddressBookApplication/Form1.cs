using System.Xml.Linq;

namespace AddressBookApplication
{
    public partial class Form1 : Form
    {
        List<string> addresses = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = txtname.Text;
            String email = txtemail.Text;
            String number = txtnumber.Text;

            //Check if the inputs are empty
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(number))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                addresses.Add(name);
                addresses.Add(email);
                addresses.Add(number);

                addressBook.DataSource = null;
                addressBook.DataSource = addresses;

                // Clear the text boxes after adding the entry
                txtname.Clear();
                txtemail.Clear();
                txtnumber.Clear();
            }        
        }
    }
}
