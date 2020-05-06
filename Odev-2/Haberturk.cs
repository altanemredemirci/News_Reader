using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2
{
    public class Haberturk:News
    {
        public string Name { get { return "HABERTURK"; } }

        public override string Url { get { return "https://www.haberturk.com/rss/manset.xml"; } }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
