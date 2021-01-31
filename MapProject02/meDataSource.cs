using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapProject02
{
    public static  class meDataSource
    {

        public static List<List<List<List<double>>>> readJson( )  //读json文件，返回一个多层list
        {
            string pathstring = meSupFunc.GetProjectRootPath() + "\\jsMap001.json";
            using (StreamReader r = new StreamReader(pathstring))
            {
                List<List<List<List<double>>>> ListMapPoint = new List<List<List<List<double>>>>();
                string json = r.ReadToEnd();
                Root j1 = JsonConvert.DeserializeObject<Root>(json);
                ListMapPoint = j1.features[0].geometry.coordinates;

                return ListMapPoint;

                //string aa="";
                //for(int i=0;i<ListMapPoint.Count();i++)
                //{
                //    aa += ListMapPoint[i][0][0][0].ToString();
                //}
                //Console.WriteLine(a.ToString());
                //return aa;

            }
        }







    }
}
