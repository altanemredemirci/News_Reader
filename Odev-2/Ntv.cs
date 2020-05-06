using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2
{
    public class Ntv:News
    {

        public string Name { get { return "NTV"; } }
        public override string Url { get { return "https://www.ntv.com.tr/gundem.rss"; } }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
