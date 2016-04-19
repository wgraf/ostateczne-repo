using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vnvbnvnvbnvbn
{
    public partial class Form1 : Form
    {
        database dbdata = new database();

        public Form1()
        {
            InitializeComponent();
            this.listBox1.DataSource = dbdata.jtttdata.ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            sendemaildata data = new sendemaildata();

            data.name = namebox.Text;
            data.text = textbox.Text;
            data.address = addressbox.Text;
            data.url = urlbox.Text;

            dbdata.jtttdata.Add(data);

            dbdata.SaveChanges();
            listBox1.DataSource = dbdata.jtttdata.ToList();

        }

        private void sendbtn_Click(object sender, EventArgs e)
        {

            foreach(sendemaildata data in dbdata.jtttdata.ToList())
            {
                getinfo info = new getinfo(data.url,data.text);
                string imgurl=info.PrintPageNodes();
                if (imgurl != ":(")
                {
                    getimg img = new getimg();
                    send sendmsg = new send();
                    sendmsg.SendEmail(data.address, img.Downloadimg(imgurl));
                }
                
                //data.parseSiteWithKeyword();

            }

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            foreach(sendemaildata data in listBox1.Items)
            {
                dbdata.jtttdata.Remove(data);
            }
            dbdata.SaveChanges();
            listBox1.DataSource=dbdata.jtttdata.ToList();

        }

        private void serbtn_Click(object sender, EventArgs e)
        {
            foreach (sendemaildata data in dbdata.jtttdata.ToList())
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Windows\Temp\" + "info.txt"))
                {
                    sw.WriteLine(dbdata.jtttdata.ToList().Count.ToString());
                }
                using (StreamWriter writer = new StreamWriter(@"C:\Windows\Temp\" + "info.txt", true))
                {
                    writer.Write(data.name + "\r\n");
                    writer.Write(data.text + "\r\n");
                    writer.Write(data.url + "\r\n");
                    writer.Write(data.address + "\r\n");
                }
            }
        }

   
    }
}
