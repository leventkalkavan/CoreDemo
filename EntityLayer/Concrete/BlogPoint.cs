using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class BlogPoint
    {
        public int BlogPointID { get; set; }
        public int BlogID { get; set; }
        public int BlogTotalPoint { get; set; }
        public int BlogPointCount { get; set; }
    }
}
