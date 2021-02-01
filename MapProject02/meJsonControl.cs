using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MapProject02
{
    public  class meJsonControl
    {
        private List<List<List<List<double>>>> _JsonList;
        public  meJsonControl()
        {
            _JsonList = meDataSource.readJson();
        }

        public  void DrawMap(double zoom, int disX, int disY, Control control)
        {
            for (int i = 0; i < _JsonList.Count(); i++)
            {
                DrawPolygon(GetPointList(zoom, disX, disY, _JsonList[i][0], control), control);
            }
        }


        public  void DrawPolygon(Point[] PointList , Control control)
        {
            Graphics g = control.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);

            g.DrawPolygon(pen, PointList);
        }



        public  Point[] GetPointList(double zoom, int disX,int disY, List<List<double>> readJson, Control control) 
        {
            Point[] pointlist = new Point[readJson.Count()];



            for (int i = 0; i < readJson.Count(); i++)
            {
                pointlist[i].X = (int)(readJson[i][0] * zoom) + disX ;
                pointlist[i].Y = control.Height -((int)(readJson[i][1] * zoom) +disY);
            }




            return pointlist;
        }



        ////reject
        //public string  readJson2()
        //{
        //    string pathstring = meSupFunc.GetProjectRootPath() + "\\jsMap001.json";

        //    StreamReader sr = new StreamReader(pathstring , Encoding.UTF8);
        //    JObject o = JObject.Parse(sr.ReadToEnd());

        //    JToken jprop = o["coordinates"];


        //    //List<List<List<List<double>>>> jlst = jprop.ToList().ToList().ToList().ToList();

        //    //return jlst[0].ToString();
        //    return "";
        //}

        ////reject
        //public string readJson3()
        //{

        //    string pathstring = meSupFunc.GetProjectRootPath() + "\\jsMap001.json";

        //    StreamReader sr = new StreamReader(pathstring, Encoding.UTF8);
        //    JObject o = JObject.Parse(sr.ReadToEnd());

        //    JToken jprop = o["features"];

        //    //JToken jprop = o["grometry"];
        //    List<JToken> jlst = jprop.ToList();
        //    for (int i = 0; i < jlst.Count; i++)
        //    {

        //        //do sth
        //    }
        //    return "";
        //    //string jtw = (string)jlst[i]["geometry"]["type"];
        //}

    }
}
