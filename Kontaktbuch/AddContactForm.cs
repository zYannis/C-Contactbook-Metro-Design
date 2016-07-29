using System;
using MetroFramework;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontaktbuch
{
    public partial class AddContactForm : MetroFramework.Forms.MetroForm
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if ((this.firstnamebox.Text == "") || (this.lastnamebox.Text == "") || (this.streetbox.Text == "") || (this.telephonenumberbox.Text == "") || (this.housenumberbox.Text == "") || (this.citybox.Text == "") || (this.CountryBox.Text == "") || (this.emailbox.Text == "") || (this.skypebox.Text == "") || (this.birthday.Text == "") || (this.nickname.Text == ""))
            {

                MetroMessageBox.Show(this, "Bitte fülle alle Felder aus. Setze für nicht unbekannte Daten '/' ein.", "Fehler.",  MessageBoxButtons.OK, MessageBoxIcon.Stop,135);
            }
            else
            {
                Contact c = new Contact(this.firstnamebox.Text, this.lastnamebox.Text, this.streetbox.Text, this.telephonenumberbox.Text, this.housenumberbox.Text, this.citybox.Text, this.CountryBox.Text, this.emailbox.Text, this.skypebox.Text, this.nickname.Text, this.birthday.Text);
                c.save();
            }
        }
    }
}
