using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Controls;

namespace Kontaktbuch
{
    class NameTag
    {
     
        public MetroLabel ContactName;
        public NameTag()
        {
        }


        public MetroLabel renderNameTag(int i, int y)
        {
            if(i <= Page.maxlistings-1) {
                try
                {
                    Contact contact = Page.pages[Page.currentpage].contactlist[i];
                    String display = "» " + contact.firstname + " " + contact.lastname;
                    this.ContactName = new MetroLabel();
                    this.ContactName.AutoSize = true;
                    this.ContactName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    this.ContactName.Location = new System.Drawing.Point((140 / 2), y);
                    this.ContactName.Name = contact.firstname + contact.lastname;
                    this.ContactName.Size = new System.Drawing.Size(45, 19);
                    this.ContactName.TabIndex = 0;
                    this.ContactName.Click += label_Click;
                    this.ContactName.Text = display;
                }catch(ArgumentOutOfRangeException e)
                {
                    e.ToString();
                }

            }

            return ContactName;

        }

        private void label_Click(object sender, EventArgs e)
        {

            Methods.openProfile(new Contact(Methods.names[((MetroLabel)sender).Name]));

        }



    }
}
