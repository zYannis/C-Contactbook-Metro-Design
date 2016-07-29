using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Kontaktbuch
{
    public partial class KontaktBuch : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroButton NextSite;
        private MetroFramework.Controls.MetroButton lastSite;
        List<Contact> clist;
        
        public KontaktBuch()
        {
            InitializeComponent();
        }

        private void KontaktBuch_Load(object sender, EventArgs e)
        {

            clist = new List<Contact>();
            for (int i = 0; i < Contact.getContactSize(); i++)
            {

                Contact c = new Contact(Contact.getContacts()[i]);
                clist.Add(c);
            }

            Page p = new Page(clist);
            setFormContent();

        }

        private void LastSite_Click(object sender, EventArgs e)
        {
            Page.currentpage -= 1;
            this.Refresh();
            this.Invalidate();
            setFormContent();
        }

        private void NextSite_Click(object sender, EventArgs e)
        {
            Page.currentpage += 1;
           
            this.Refresh();
            this.Invalidate();
            setFormContent();
        }


        public void setFormContent()
        {
            this.Controls.Clear();
            Debug.WriteLine(Page.currentpage + "/" + Page.pages.Count);
            this.NextSite = new MetroFramework.Controls.MetroButton();
            this.lastSite = new MetroFramework.Controls.MetroButton();
       
     
            int y = 40;
            NameTag tag = new NameTag();
            for (int i = 0; i < Page.pages[Page.currentpage].contactlist.Count; i++)
            {
                y += 25;

                this.Controls.Add(tag.renderNameTag(i, y));

            }



            if (Page.currentpage+1 != Page.pages.Count)
            {
                // 
                // NextSite
                // 
                this.NextSite.Location = new System.Drawing.Point(178, 342);
                this.NextSite.Name = "NextSite";
                this.NextSite.Size = new System.Drawing.Size(79, 23);
                this.NextSite.TabIndex = 0;
                this.NextSite.Text = "Nächste Seite";
                this.NextSite.UseSelectable = true;
                this.NextSite.Click += NextSite_Click;
                this.Controls.Add(this.NextSite);
            }
            // 
            // lastSite
            // 
            if (Page.currentpage >= 1)
            {
                this.lastSite.Location = new System.Drawing.Point(23, 342);
                this.lastSite.Name = "lastSite";
                this.lastSite.Size = new System.Drawing.Size(79, 23);
                this.lastSite.TabIndex = 1;
                this.lastSite.Click += LastSite_Click;
                this.lastSite.Text = "Letzte Seite";
                this.lastSite.UseSelectable = true;
                this.Controls.Add(this.lastSite);
            }
        }
    }
}
