using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontaktbuch
{
    class Page
    {

        public static int maxlistings = 10;
        public List<Contact> contactlist { get; set; }
        public static List<Page> pages = new List<Page>();
        public static int currentpage = 0;


        public Page(List<Contact> contactlist)
        {
            this.contactlist = contactlist;
            pages.Add(this);
            if (contactlist.Count > maxlistings)
            {

                List<Contact> clist = new List<Contact>();
                for(int i = maxlistings; i < contactlist.Count; i++)
                {
                    clist.Add(contactlist[i]);
                    contactlist.RemoveAt(i);
                }
                Page page = new Page(clist);
         
            }
            



        }

    }
}
