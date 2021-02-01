using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace MapProject02
{
    public partial class FormMapBoard : Form
    {
        meJsonControl meJC = new meJsonControl(); //实例化mejsoncotrol
        double zoom = 7;
        int disX = -450;
        int disY = -80;

        public FormMapBoard()
        {
            InitializeComponent();
        }

        private void FormMapBoard_Load(object sender, EventArgs e)
        {
           
        }


        private void btnJsonLoad_Click(object sender, EventArgs e)
        {
            BaiduMapBrowser.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Refresh();
            zoom = 7;
            disX = -450;
            disY = -80;
            meJC.DrawMap(zoom, disX, disY, this.pictureBox1);
            //meJC.DrawPolygon(meJC.GetPointList(zoom,disX,disY,meDataSource.readJson()[0][0],this.pictureBox1), this.pictureBox1);

            //btnJsonLoad.Text= jsc.readJson();

            //meJsonControl.DrawPolygon()
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            BaiduMapBrowser.Visible = true;
            BaiduMapBrowser.ScriptErrorsSuppressed = true;
            string pathName = meSupFunc.GetProjectRootPath() + "\\BaiduMapHtml.html";
            BaiduMapBrowser.Navigate(pathName);


            ////Chart chart = new Chart();
            ////ChartType chartType = ChartType.Histogram;
            ////string path = @"..\..\JSON.json";
            //string path = meSupFunc.GetProjectRootPath() + "\\jsMap001.json";
            //DataSource dataSource = new JsonDataSource();
            //List<Composition> Compositions = dataSource.GetDataList(path);
            //string aa = Compositions.ToString();

            ////chart.Compositions.AddRange(Compositions);
            ////chart.Draw(chartType);
            ////chart.Save();
        }

        Point mouseDownPoint;
        bool isSelected = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint.X = Cursor.Position.X;  //注：全局变量mouseDownPoint前面已定义为Point类型

                mouseDownPoint.Y = Cursor.Position.Y;
                isSelected = true;
            }
        }

        int mark = 0;
        Bitmap stBtm=   new  Bitmap(1, 1);
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            mark++;
            if (mark % 25 != 1)
            {
                return;
            }
            if (isSelected && IsMouseInPanel())
            {

                //pictureBox1.Image = null;
                pictureBox1.Refresh();
                //pictureBox1.Invalidate();
                disX =disX+(Cursor.Position.X - mouseDownPoint.X);
                disY =disY- (Cursor.Position.Y - mouseDownPoint.Y);
                meJC.DrawMap(zoom, disX, disY, this.pictureBox1);
                //meJC.DrawPolygon(meJC.GetPointList(zoom, disX, disY, meDataSource.readJson()[0][0], this.pictureBox1), this.pictureBox1);

                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
        }
        private bool IsMouseInPanel()
        {
            if (this.pictureBox1.Left < PointToClient(Cursor.Position).X
            && PointToClient(Cursor.Position).X < this.pictureBox1.Left + this.pictureBox1.Width
            && this.pictureBox1.Top < PointToClient(Cursor.Position).Y
            && PointToClient(Cursor.Position).Y < this.pictureBox1.Top + this.pictureBox1.Height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isSelected = false;
        }


        //int markzoom=0;
        double zoomtime;
        private void pictureBox1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //MessageBox.Show("滚动事件已被捕捉");
            //markzoom++;
            //if (markzoom % 25 != 1)
            //{
            //    //return;
            //}
            pictureBox1.Refresh();

            {
                if (e.Delta > 0)
                { zoomtime = 1.1; }
                else
                { zoomtime = 0.9; }
                
            }
            int poX = Cursor.Position.X - disX;  //注：全局变量mouseDownPoint前面已定义为Point类型
            int poY = Cursor.Position.Y - disY;

            int xadd = (int)((poX  - poX/zoomtime)  );
            int yadd = (int)((poY  - poY/zoomtime)  );
            meJC.DrawMap(zoom *= zoomtime, disX -= xadd, disY -= yadd, this.pictureBox1);
            //meJC.DrawPolygon(meJC.GetPointList(zoom *= zoomtime, disX-=xadd, disY-=yadd, meDataSource.readJson()[0][0], this.pictureBox1), this.pictureBox1);




            //Size t = new Size(0, 0); //t的属性为滚轮滚动的变化值可以结合控件的尺寸(+t)，实现滚轮随放。
            //t.Width += e.Delta;
            //t.Height += e.Delta;
        }
    }
}
