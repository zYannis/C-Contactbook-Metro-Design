using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontaktbuch
{
    class Methods
    {

        private static Random random = new Random();


        public static Dictionary<String, String> names = new Dictionary<String, String>();

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void createPaths()
        {
            if (!Directory.Exists("contact"))
            {
                Directory.CreateDirectory("contact");
            }
        }

       public static void openProfile()
        {
            Application.Run(new KontaktBuch());
         
        }

        public static void openAddContactGUI()
        {
            Application.Run(new AddContactForm());

        }

        public static void openProfile(Contact c)
        {
            Profile pr = new Profile(c);
            pr.Show();

        }

        
    }
}
