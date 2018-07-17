using System.Windows.Forms;
using System.Text.RegularExpressions;
using System;

namespace RegularExpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (!IsValidName(textName.Text))
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");

            if (!IsValidPhone(textPhone.Text))
            {
                MessageBox.Show("The phone number is not a valid US phone number");
            }
            else
            {
                textPhone.Text = ReformatPhone(textPhone.Text);
            }

            if (!IsValidEmail(textEmail.Text))
                MessageBox.Show("The e-mail address is not valid.");
        }

        public bool IsValidName(string text)
        {
            return Regex.IsMatch(text, @"^([A-Za-z]*\s*)+$") ? true : false;
        }

        public bool IsValidPhone(string text)
        {
            return Regex.IsMatch(text, @"^((\(\d{3}\)?)|(\d{3}-))?\d{3}-\d{4}$") ? true : false;  
        }

        public bool IsValidEmail(string text)
        {
            return Regex.IsMatch(text, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") ? true : false;
        }

        public static string ReformatPhone(string s)
        {
            Match m = Regex.Match(s, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$");

            return String.Format("({0}) {1}-{2}",
                                 m.Groups[1],
                                 m.Groups[2],
                                 m.Groups[3]);
        }
    }
}
