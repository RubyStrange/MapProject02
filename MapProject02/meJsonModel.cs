using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapProject02
{
    //如果好用，请收藏地址，帮忙分享。
    public class Parent
    {
        /// <summary>
        /// 
        /// </summary>
        public string adcode { get; set; }
    }

    public class Propertie
    {
        /// <summary>
        /// 
        /// </summary>
        public int adcode { get; set; }
        /// <summary>
        /// 中华人民共和国
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<double> center { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<double> centroid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int childrenNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Parent parent { get; set; }
    }

    public class geometry
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<List<List<double>>>> coordinates { get; set; }
    }

    public class FeaturesItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Propertie propertie { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public geometry geometry { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<FeaturesItem> features { get; set; }
    }


}
