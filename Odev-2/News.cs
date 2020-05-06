using CodeHollow.FeedReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2
{
    public class News
    {                
        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
     
        public DateTime? Date { get; set; }
        public virtual string Url { get; set; }
        //public virtual void GetFeed(string url)
        //{
        //    List<News> news = new List<News>();
        //    Feed feed = FeedReader.Read(url);
        //    foreach (var item in feed.Items)
        //    {
        //        this.ID = item.Id;
        //        this.Link = item.Link;
        //        this.Title = item.Title;
        //        this.Description = item.Description;
        //        news.Add()
        //    }
        //}

    }
}
