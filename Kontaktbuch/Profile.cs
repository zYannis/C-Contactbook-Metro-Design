using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontaktbuch
{
    public partial class Profile : MetroFramework.Forms.MetroForm
    {
        Contact c;
        public Profile(Contact c)
        {
            InitializeComponent();

            this.c = c;
            


        }

        private void birthday_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            this.Firstname.Text = this.Firstname.Text + " " + c.firstname;
            this.lastname.Text = this.lastname.Text + " " + c.lastname;
            this.street.Text = this.street.Text + " " + c.street;
            this.housenumber.Text = this.housenumber.Text + " " + c.housenumber;
            this.City.Text = this.City.Text + " " + c.city;
            this.country.Text = this.country.Text + " " + c.country;
            this.phonenumber.Text = this.phonenumber.Text + " " + c.phonenumber;
            this.email.Text = this.email.Text + " " + c.email;
            this.skype.Text = this.skype.Text + " " + c.skype;
            this.Nickname.Text = this.Nickname.Text + " " + c.nickname;
            this.birthday.Text = this.birthday.Text + " " + c.birthday;




        }
    }
}
