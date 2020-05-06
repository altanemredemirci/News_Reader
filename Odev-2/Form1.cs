using CodeHollow.FeedReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Odev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lstbx_basliklar.DisplayMember = "Title";
            cmbx_siteadi.Items.Clear();
            Assembly asb = Assembly.GetExecutingAssembly();
            Type[] types = asb.GetTypes();
            foreach (Type item in types)
            {
                if (item.IsClass && item.BaseType.Name == "News")
                {
                    News news = (News)Activator.CreateInstance(item);
                    cmbx_siteadi.Items.Add(news);
                }
            }
        }
        List<News> news = new List<News>();
        News n;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = lstbx_basliklar.SelectedItem;
        }

        private void cmbx_siteadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbx_basliklar.Items.Clear();
            News news = (News)cmbx_siteadi.SelectedItem;

            Feed feed = FeedReader.Read(news.Url);
            foreach (var item in feed.Items)
            {
                News n = new News();
                n.ID = item.Id;
                n.Title = item.Title.Replace("&#39;", "'").Replace("&quot;", "");
                n.Description = item.Description.Replace("&#39;", "'").Replace("&quot;", "");
                n.Url = item.Link;
                n.Date = item.PublishingDate;
                lstbx_basliklar.Items.Add(n);
            }
            #region
            //if (cmbx_siteadi.Text == "NTV")
            //{
            //    lstbx_basliklar.Items.Clear();
            //    Ntv ntv = new Ntv();
            //    Feed feed = FeedReader.Read(ntv.Url);
            //    foreach (var item in feed.Items)
            //    {
            //        ntv.ID = item.Id;
            //        ntv.Link = item.Link;
            //        ntv.Title = item.Title;
            //        ntv.Description = item.Description;
            //        lstbx_basliklar.Items.Add(ntv);
            //    }

            //}
            //else if (cmbx_siteadi.Text == "CNN")
            //{
            //    lstbx_basliklar.Items.Clear();
            //    Cnn cnn = new Cnn();
            //    Feed feed = FeedReader.Read(cnn.Url);
            //    foreach (var item in feed.Items)
            //    {
            //        cnn.ID = item.Id;
            //        cnn.Link = item.Link;
            //        cnn.Title = item.Title;
            //        cnn.Description = item.Description;
            //        lstbx_basliklar.Items.Add(cnn);
            //    }
            //}
            //else if (cmbx_siteadi.Text == "HABERTURK")
            //{
            //    lstbx_basliklar.Items.Clear();
            //    Haberturk hbrtrk = new Haberturk();
            //    Feed feed = FeedReader.Read(hbrtrk.Url);
            //    foreach (var item in feed.Items)
            //    {
            //        hbrtrk.ID = item.Id;
            //        hbrtrk.Link = item.Link;
            //        hbrtrk.Title = item.Title;
            //        hbrtrk.Description = item.Description;
            //        lstbx_basliklar.Items.Add(hbrtrk);
            //    }

            #endregion
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    News n;
        //    Feed feed = FeedReader.Read(textBox1.Text);
        //    foreach (var item in feed.Items)
        //    {
        //        n = new News();
        //        n.ID = item.Id;
        //        n.Link = item.Link;
        //        n.Title = item.Title;
        //        n.Description = item.Description;
        //        news.Add(n);
        //    }

        //    listBox1.DataSource = news;
        //    listBox1.DisplayMember = "Title";


        //}

    }
}


