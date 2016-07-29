using System;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Text;

namespace Kontaktbuch
{
    public partial class StartSeite : MetroFramework.Forms.MetroForm
    {

      

        public StartSeite()
        {
            InitializeComponent();

            for(int i = 0; i < Contact.getContactSize(); i++)
            {
                string[] lines = File.ReadAllLines(Contact.getContacts()[i], Encoding.Default);
                try
                {
                    Methods.names.Add(lines[0] + lines[1], Contact.getContacts()[i].ToString());
                }catch(ArgumentException e)
                {
                    e.StackTrace.ToString();
                }

            }
        }

        private void StartSeite_Load(object sender, EventArgs e)
        {
            Methods.createPaths();
            updateInfos();

        }


        private void updateInfos()
        {

           
            this.ContactSizeLabel.Text = "Deine Kontakte: " + Contact.getContactSize();

        }

        private void ContactBookButton_Click(object sender, EventArgs e)
        {
           
            Thread t = new Thread(new ThreadStart(Methods.openProfile));
            t.Start();
            this.Close();

        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(Methods.openAddContactGUI));
            t.Start();
            this.Close();
        }

        private void ad_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.github.com/BukkitTNT");
        }
    }
}
