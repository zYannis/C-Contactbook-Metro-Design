using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontaktbuch
{
    public class Contact
    {
        public String firstname { get; set; }
        public String lastname { get; set; }
        public String street { get; set; }
        public String housenumber { get; set; }
        public String city { get; set; }
        public String country { get; set; }
        public String phonenumber { get; set; }
        public String email { get; set; }
        public String skype { get; set; }
        public String nickname { get; set; }
        public String birthday { get; set; }

        public Contact(String firstname, String lastname, String street, String phonenumber, String housenumber, String city, String country, String email, String skype, String nickname, String birthday)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.street = street;
            this.housenumber = housenumber;
            this.city = city;
            this.country = country;
            this.phonenumber = phonenumber;
            this.email = email;
            this.skype = skype;
            this.nickname = nickname;
            this.birthday = birthday;


        }

        public Contact(String name)
        {

            string[] lines = File.ReadAllLines(name, Encoding.UTF8);
            this.firstname = lines[0];
            this.lastname = lines[1];
            this.street = lines[2];
            this.housenumber = lines[3];
            this.city = lines[4];
            this.country = lines[5];
            this.phonenumber = lines[6];
            this.email = lines[7];
            this.skype = lines[8];
            this.nickname = lines[9];
            this.birthday = lines[10];

        }

        public static int getContactSize()
        {
            DirectoryInfo di = new DirectoryInfo("contact");
            return di.GetFiles().Length;
        }

        public static string[] getContacts()
        {
            return Directory.GetFiles("contact");

        }


        public void save()
        {
            StreamWriter writer = new StreamWriter("contact\\" + Methods.RandomString(6) + ".pxct");
            writer.WriteLine(firstname);
            writer.WriteLine(lastname);
            writer.WriteLine(street);
            writer.WriteLine(housenumber);
            writer.WriteLine(city);
            writer.WriteLine(country);
            writer.WriteLine(phonenumber);
            writer.WriteLine(email);
            writer.WriteLine(skype);
            writer.WriteLine(nickname);
            writer.WriteLine(birthday);
            writer.Close();
        }



    }
}